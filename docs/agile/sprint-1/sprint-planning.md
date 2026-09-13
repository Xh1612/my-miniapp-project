# Sprint 1 Planning

**Thời gian:** 15/07/2026 – 29/07/2026 (2 tuần)

**Team:** 6 thành viên

## Thành viên nhóm

| STT | Thành viên | Vai trò chính |
|---|---|---|
| 1 | Huỳnh Đăng Khoa | UI/UX, Frontend, tích hợp giao diện |
| 2 | Nguyễn Phi Hùng | Backend, Authentication, Order Flow |
| 3 | Nguyễn Trọng Nghĩa | Database, Model, Inventory |
| 4 | Ngô Nhựt Nam | EF Core, Services, Backend Integration |
| 5 | Nguyễn Chí Hoàng | Menu, Product, Cart, Testing |
| 6 | Phạm Thị Hồng Gấm | Cart UI, Checkout UI, Staff/Shipper UI |

---

## Sprint Goal

> Hoàn thiện nền tảng chính của hệ thống website đặt món ăn Hương Quê Việt bằng ASP.NET Core MVC (.NET 8), bao gồm xác thực người dùng, cơ sở dữ liệu cốt lõi, thực đơn, tìm kiếm, chi tiết món ăn, giỏ hàng, địa chỉ giao hàng và quy trình đặt hàng.
>
> Đồng thời xây dựng luồng xử lý đơn hàng cho Nhân viên bếp và Shipper, đảm bảo trạng thái đơn hàng được kiểm soát đúng quy trình để có thể thực hiện một luồng mua hàng end-to-end từ lúc khách hàng xem món ăn, thêm vào giỏ hàng, đặt hàng cho đến khi đơn được tiếp nhận và xử lý.

---

## Task được kéo từ Product Backlog vào Sprint này

| STT | Task | User Story liên quan | Ước lượng | Người phụ trách |
|---|---|---|---:|---|
| 1 | Khởi tạo project ASP.NET Core MVC (.NET 8), cấu hình ASP.NET Core Identity | US-01 | 0.5 ngày | Nguyễn Phi Hùng |
| 2 | Tạo Area `Admin` và layout quản trị riêng | US-02 | 0.5 ngày | Nguyễn Phi Hùng |
| 3 | Thiết kế Model + DbContext cho Category/Product/Order/OrderItem và seed dữ liệu mẫu | US-03 | 1 ngày | Nguyễn Trọng Nghĩa, Ngô Nhựt Nam |
| 4 | Xây dựng trang chủ hiển thị món nổi bật và món mới nhất | US-04 | 0.5 ngày | Huỳnh Đăng Khoa |
| 5 | Xây dựng trang thực đơn, lọc theo danh mục và tìm kiếm cơ bản | US-05, US-06 | 1 ngày | Nguyễn Chí Hoàng, Huỳnh Đăng Khoa |
| 6 | Xây dựng chức năng tìm kiếm nâng cao theo giá, danh mục và mức độ cay | US-07 | 0.5 ngày | Nguyễn Phi Hùng |
| 7 | Xây dựng trang chi tiết sản phẩm và chức năng đánh giá | US-08 | 1 ngày | Nguyễn Chí Hoàng, Nguyễn Trọng Nghĩa |
| 8 | Xây dựng giỏ hàng bằng Session và View Component hiển thị số lượng | US-09 | 1 ngày | Phạm Thị Hồng Gấm, Nguyễn Chí Hoàng |
| 9 | Quản lý địa chỉ giao hàng và tính khoảng cách giao hàng | US-10, US-11 | 1 ngày | Nguyễn Phi Hùng, Ngô Nhựt Nam |
| 10 | Xây dựng quy trình đặt hàng, transaction và kiểm tra/trừ tồn kho an toàn | US-12 | 1.5 ngày | Nguyễn Trọng Nghĩa, Nguyễn Phi Hùng |
| 11 | Xây dựng giao diện xử lý đơn cho Nhân viên bếp và Shipper | US-20, US-22 | 1 ngày | Phạm Thị Hồng Gấm, Huỳnh Đăng Khoa |
| 12 | Xây dựng cơ chế kiểm soát chuyển trạng thái đơn hàng | US-21 | 0.5 ngày | Nguyễn Phi Hùng, Ngô Nhựt Nam |
| 13 | Xây dựng chức năng hủy đơn khi đơn còn ở trạng thái cho phép | US-14 | 0.5 ngày | Nguyễn Chí Hoàng |

**Tổng ước lượng:** khoảng **10.5 ngày công**, được thực hiện song song bởi các thành viên trong Sprint.

---

## Phân công theo nhóm chức năng

### 1. Authentication & Admin

- Nguyễn Phi Hùng
  - ASP.NET Core Identity
  - Authentication / Authorization
  - Admin Area
  - Tìm kiếm nâng cao
  - Kiểm soát trạng thái đơn hàng

### 2. Database & Backend

- Nguyễn Trọng Nghĩa
  - Model
  - Database
  - Inventory
  - Order / OrderItem
  - Review

- Ngô Nhựt Nam
  - EF Core
  - DbContext
  - Services
  - Address
  - Backend integration
  - Order status

### 3. UI/UX & Frontend

- Huỳnh Đăng Khoa
  - Trang chủ
  - Layout
  - Menu
  - Product UI
  - Staff/Shipper UI
  - Responsive UI

- Phạm Thị Hồng Gấm
  - Cart UI
  - Checkout UI
  - Address UI
  - Staff/Shipper UI

### 4. Product & Testing

- Nguyễn Chí Hoàng
  - Menu
  - Product detail
  - Search
  - Cart integration
  - Review
  - Order cancellation
  - Testing

---

## Definition of Done

Một task được xem là hoàn thành khi:

- [ ] Chức năng đã được code đầy đủ.
- [ ] Chức năng chạy được trên project ASP.NET Core MVC.
- [ ] Không còn lỗi compile liên quan đến task.
- [ ] Đã kiểm thử chức năng bằng thao tác thực tế.
- [ ] Đã kiểm tra các trường hợp nhập dữ liệu hợp lệ.
- [ ] Đã kiểm tra ít nhất một trường hợp lỗi dự kiến.
- [ ] Giao diện hiển thị đúng trên các trang liên quan.
- [ ] Code được tích hợp vào nhánh chính của project.
- [ ] Không làm hỏng các chức năng đã hoàn thành trước đó.

---

## Sprint Backlog

Các User Story được lựa chọn cho Sprint 1:

| User Story | Nội dung | Priority |
|---|---|---|
| US-01 | Thiết lập ASP.NET Core MVC và Authentication | High |
| US-02 | Xây dựng Admin Area | High |
| US-03 | Xây dựng Model và Database cốt lõi | High |
| US-04 | Trang chủ | High |
| US-05 | Trang thực đơn và lọc danh mục | High |
| US-06 | Tìm kiếm món ăn | High |
| US-07 | Tìm kiếm nâng cao | Medium |
| US-08 | Chi tiết món ăn và đánh giá | Medium |
| US-09 | Giỏ hàng | High |
| US-10 | Quản lý địa chỉ giao hàng | High |
| US-11 | Tính phí giao hàng theo khoảng cách | Medium |
| US-12 | Checkout và xử lý tồn kho | High |
| US-14 | Hủy đơn hàng | Medium |
| US-20 | Nhân viên bếp xử lý đơn mới | High |
| US-21 | Kiểm soát trạng thái đơn hàng | High |
| US-22 | Shipper xử lý đơn sẵn sàng giao | High |

---

## Rủi ro đã xác định trước Sprint

### Rủi ro 1: Tích hợp nhiều chức năng

Các chức năng như Cart, Checkout, Inventory và Order Status có quan hệ với nhau. Nếu thay đổi Model hoặc Database trong quá trình phát triển có thể ảnh hưởng đến các chức năng đã hoàn thành.

**Biện pháp:**
- Thống nhất Model và Database trước khi phát triển.
- Kiểm tra lại các chức năng liên quan sau mỗi thay đổi lớn.

### Rủi ro 2: Transaction và tồn kho

Quy trình đặt hàng cần kiểm tra tồn kho và cập nhật dữ liệu trong transaction. Có thể phát sinh lỗi khi transaction bị rollback hoặc xử lý exception.

**Biện pháp:**
- Kiểm thử trường hợp đặt hàng bình thường.
- Kiểm thử trường hợp sản phẩm không đủ tồn kho.
- Kiểm tra rollback khi xảy ra lỗi.

### Rủi ro 3: Authentication và Authorization

Identity và phân quyền Admin/Staff/Shipper có thể gây lỗi khi truy cập các Area hoặc Controller.

**Biện pháp:**
- Kiểm tra quyền truy cập bằng từng loại tài khoản.
- Kiểm tra các trường hợp truy cập sai quyền.

### Rủi ro 4: Giao diện và Backend tích hợp không đồng bộ

Một số API/Controller có thể thay đổi dữ liệu trả về trong quá trình phát triển khiến giao diện bị lỗi.

**Biện pháp:**
- Thống nhất Model/ViewModel trước khi tích hợp.
- Test lại UI sau khi Backend thay đổi.

---

## Kế hoạch kiểm thử cuối Sprint

Trước khi kết thúc Sprint 1, nhóm sẽ kiểm tra các luồng chính:

### Luồng khách hàng

1. Đăng ký tài khoản.
2. Đăng nhập.
3. Xem trang chủ.
4. Xem thực đơn.
5. Lọc theo danh mục.
6. Tìm kiếm món ăn.
7. Xem chi tiết món ăn.
8. Thêm món vào giỏ hàng.
9. Quản lý địa chỉ giao hàng.
10. Checkout.
11. Đặt hàng thành công.
12. Hủy đơn nếu đơn đang ở trạng thái cho phép.

### Luồng Nhân viên bếp

1. Đăng nhập bằng tài khoản nhân viên.
2. Xem danh sách đơn mới.
3. Tiếp nhận đơn.
4. Cập nhật trạng thái đơn.

### Luồng Shipper

1. Đăng nhập bằng tài khoản Shipper.
2. Xem đơn đã sẵn sàng giao.
3. Nhận đơn giao hàng.
4. Cập nhật trạng thái giao hàng.

---

## Kết quả mong đợi cuối Sprint

Sau khi kết thúc Sprint 1, hệ thống phải có thể thực hiện được một luồng cơ bản:

```text
Khách hàng
    ↓
Đăng nhập / Đăng ký
    ↓
Xem thực đơn
    ↓
Tìm kiếm / Lọc món
    ↓
Xem chi tiết món
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
Cập nhật trạng thái
    ↓
Shipper nhận đơn
    ↓
Xử lý giao hàng
