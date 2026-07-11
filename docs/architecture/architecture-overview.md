# Kiến trúc hệ thống — Hương Quê Việt

## 1. Tổng quan

Hệ thống được xây dựng theo mô hình **MVC (Model – View – Controller)** trên nền tảng ASP.NET Core (.NET 8), mở rộng thêm các kỹ thuật tổ chức mã nguồn để tăng khả năng bảo trì:

- **Area** — tách biệt hoàn toàn khu vực quản trị (`Areas/Admin`) khỏi luồng khách hàng, có layout giao diện riêng.
- **Partial View** — tái sử dụng khối giao diện lặp lại (`_ProductCard`) giữa nhiều trang.
- **View Component** — khối giao diện có logic riêng, độc lập với Controller chứa nó (`CartSummary` ở Navbar).
- **Service Layer** — tách nghiệp vụ phức tạp (mã giảm giá, thanh toán VNPay, gửi thông báo) khỏi Controller, đăng ký qua Dependency Injection.

## 2. Sơ đồ thành phần (Component Diagram dạng văn bản)

```
┌─────────────────────────────────────────────────────────────┐
│                        Trình duyệt (Client)                   │
│   Razor View + CSS thương hiệu (khách hàng)                   │
│   Razor View + Bootstrap (Area Admin)                         │
│   JavaScript: SignalR client, Chart.js                        │
└───────────────────────────┬────────────────────────────────────┘
                             │ HTTP / WebSocket
┌───────────────────────────▼────────────────────────────────────┐
│                    ASP.NET Core MVC (.NET 8)                    │
│  ┌───────────────┐  ┌──────────────────┐  ┌──────────────────┐ │
│  │  Controllers   │  │  Areas/Admin/     │  │  API Controllers │ │
│  │  (khách hàng)  │  │  Controllers      │  │  (JWT, JSON)      │ │
│  └───────┬────────┘  └────────┬─────────┘  └────────┬─────────┘ │
│          │                    │                      │           │
│  ┌───────▼────────────────────▼──────────────────────▼────────┐ │
│  │                     Service Layer                            │ │
│  │  CouponService · VnPayService · NotificationService          │ │
│  │  OrderStatusMachine · DistanceHelper                          │ │
│  └───────────────────────────┬──────────────────────────────────┘ │
│                               │                                    │
│  ┌────────────────────────────▼─────────────────────────────────┐│
│  │           Entity Framework Core (AppDbContext)                ││
│  └────────────────────────────┬─────────────────────────────────┘│
└───────────────────────────────┼───────────────────────────────────┘
                                 │
                    ┌────────────▼────────────┐
                    │   SQL Server (LocalDB)    │
                    └───────────────────────────┘

  Dịch vụ ngoài: VNPay Sandbox (thanh toán) · Mailtrap SMTP (email)
```

## 3. Xác thực & Phân quyền

Hệ thống dùng **hai cơ chế xác thực song song, không xung đột**:

| Cơ chế | Đối tượng dùng | Cách hoạt động |
|---|---|---|
| Cookie (ASP.NET Core Identity) | Trình duyệt web | Trình duyệt tự đính kèm cookie mã hóa ở mọi request sau khi đăng nhập |
| JWT Bearer | API (mô phỏng app di động) | Client tự lưu token, tự gửi kèm header `Authorization: Bearer <token>` |

Phân quyền dựa trên 4 **Role** cố định: `Admin`, `Staff`, `Shipper`, `Customer`, áp dụng bằng `[Authorize(Roles = "...")]` ngay tại tầng Controller.

## 4. Luồng dữ liệu quan trọng nhất: Đặt hàng

1. Client gửi request `POST /Orders/Checkout` kèm địa chỉ, phương thức thanh toán, mã giảm giá (nếu có).
2. Controller mở một **database transaction**.
3. Tra cứu `DeliveryZone` + tính khoảng cách (Haversine) → phí ship.
4. Với từng sản phẩm trong giỏ: kiểm tra & trừ tồn kho (theo nguyên liệu nếu có công thức, theo món nếu không).
5. Áp mã giảm giá qua `CouponService` (nếu có).
6. Ghi `Order` + `OrderItem` vào database.
7. Commit transaction — nếu bất kỳ bước 3-6 lỗi, toàn bộ rollback.
8. Gửi thông báo (Email/SMS) — lỗi ở bước này **không** làm rollback đơn hàng đã commit.
9. Chuyển hướng sang VNPay (nếu thanh toán online) hoặc trang xác nhận.

## 5. Công nghệ theo tầng

| Tầng | Công nghệ |
|---|---|
| Frontend | Razor View, CSS tùy biến, Bootstrap 5 (Admin), Chart.js, SignalR client |
| Backend | ASP.NET Core MVC (.NET 8), C# |
| ORM | Entity Framework Core (Code First) |
| Database | Microsoft SQL Server |
| Auth | ASP.NET Core Identity (cookie) + JWT Bearer (API) |
| Realtime | SignalR |
| Thanh toán | VNPay (Sandbox) |
| Thông báo | SMTP qua Mailtrap (email), log-based mock (SMS) |
| Kiểm thử | xUnit + EF Core InMemory |
