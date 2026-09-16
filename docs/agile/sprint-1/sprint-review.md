# Sprint Review — Sprint 1

**Ngày:** 27/06/2026

**Sprint:** Sprint 1

**Thời gian Sprint:** 16/06/2026 – 27/06/2026

## Người tham dự

### Nhóm phát triển

| STT | Thành viên | Vai trò chính |
|---|---|---|
| 1 | Huỳnh Đăng Khoa | UI/UX, Frontend |
| 2 | Nguyễn Phi Hùng | Backend, Authentication, Order Flow |
| 3 | Nguyễn Trọng Nghĩa | Database, Model, Inventory |
| 4 | Ngô Nhựt Nam | EF Core, Services, Backend Integration |
| 5 | Nguyễn Chí Hoàng | Product, Menu, Cart, Testing |
| 6 | Phạm Thị Hồng Gấm | Cart UI, Checkout UI, Staff/Shipper UI |

### Người hướng dẫn

- Giảng viên hướng dẫn

---

## Sprint Goal đã đạt được?

✅ **Đạt phần lớn mục tiêu của Sprint 1.**

Trong Sprint 1, nhóm đã xây dựng được nền tảng chính của website đặt món ăn **Hương Quê Việt** bằng ASP.NET Core MVC (.NET 8), đồng thời hoàn thiện được luồng mua hàng cơ bản từ phía khách hàng đến quá trình xử lý đơn hàng.

Luồng chính có thể thực hiện:

```text
Đăng ký / Đăng nhập
        ↓
Xem trang chủ
        ↓
Xem thực đơn
        ↓
Tìm kiếm / Lọc món ăn
        ↓
Xem chi tiết món ăn
        ↓
Thêm vào giỏ hàng
        ↓
Chọn địa chỉ giao hàng
        ↓
Checkout
        ↓
Đặt hàng
        ↓
Nhân viên bếp tiếp nhận
        ↓
Cập nhật trạng thái đơn
        ↓
Shipper xử lý đơn
