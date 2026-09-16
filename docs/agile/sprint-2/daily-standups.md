# Daily Standups — Sprint 1

## Sprint Information

- **Project:** Hương Quê Việt
- **Sprint:** Sprint 1
- **Thời gian:** 16/06/2026 – 27/06/2026
- **Số thành viên:** 6

### Thành viên

1. Huỳnh Đăng Khoa
2. Nguyễn Phi Hùng
3. Nguyễn Trọng Nghĩa
4. Ngô Nhựt Nam
5. Nguyễn Chí Hoàng
6. Phạm Thị Hồng Gấm

---

## Thứ Hai, 16/06/2026

### Huỳnh Đăng Khoa

- **Hôm qua:** Bắt đầu Sprint, thống nhất Sprint Goal và phạm vi công việc.
- **Hôm nay:**
  1. Thiết kế Header và Navigation cho website.
  2. Xây dựng layout tổng thể trang chủ.
  3. Thiết kế khu vực món ăn nổi bật.
- **Blockers:** Không có.

### Nguyễn Phi Hùng

- **Hôm qua:** Tham gia Sprint Planning và nhận nhiệm vụ Authentication.
- **Hôm nay:**
  1. Cấu hình ASP.NET Core Identity.
  2. Thiết lập chức năng đăng ký tài khoản.
  3. Thiết lập chức năng đăng nhập.
- **Blockers:** Không có.

### Nguyễn Trọng Nghĩa

- **Hôm qua:** Tham gia thống nhất cấu trúc Database cho Sprint 1.
- **Hôm nay:**
  1. Xây dựng Model Category.
  2. Xây dựng Model Product.
  3. Thiết lập quan hệ Category - Product.
- **Blockers:** Không có.

---

## Thứ Ba, 17/06/2026

### Huỳnh Đăng Khoa

- **Hôm qua:** Đã xây dựng Header, Navigation và layout cơ bản của trang chủ.
- **Hôm nay:**
  1. Hoàn thiện Hero Section của trang chủ.
  2. Thiết kế khu vực món ăn mới nhất.
  3. Điều chỉnh Responsive cho trang chủ.
- **Blockers:** Không có.

### Nguyễn Phi Hùng

- **Hôm qua:** Đã cấu hình Identity và tạo chức năng đăng ký, đăng nhập.
- **Hôm nay:**
  1. Thiết lập Authorization cho các Role.
  2. Tạo Area Admin.
  3. Tạo Admin Dashboard cơ bản.
- **Blockers:** Gặp lỗi `UserManager<IdentityUser>` do một số View vẫn sử dụng `IdentityUser` thay vì `ApplicationUser`.

### Nguyễn Trọng Nghĩa

- **Hôm qua:** Đã xây dựng Category và Product Model.
- **Hôm nay:**
  1. Xây dựng Model Order.
  2. Xây dựng Model OrderItem.
  3. Thiết lập quan hệ Order - OrderItem.
- **Blockers:** Không có.

### Nguyễn Chí Hoàng

- **Hôm qua:** Nhận nhiệm vụ phát triển chức năng Menu.
- **Hôm nay:**
  1. Xây dựng trang Menu.
  2. Hiển thị danh sách món ăn.
  3. Hiển thị danh sách Category.
- **Blockers:** Không có.

---

## Thứ Tư, 18/06/2026

### Nguyễn Phi Hùng

- **Hôm qua:** Đã thiết lập Authorization và tạo Admin Area.
- **Hôm nay:**
  1. Hoàn thiện Admin Dashboard.
  2. Thiết lập quyền truy cập khu vực Admin.
  3. Kiểm tra luồng đăng nhập theo Role.
- **Blockers:** Đã xử lý lỗi `UserManager<IdentityUser>` bằng cách chuyển sang `ApplicationUser`.

### Nguyễn Trọng Nghĩa

- **Hôm qua:** Đã xây dựng Order và OrderItem.
- **Hôm nay:**
  1. Cấu hình ApplicationDbContext.
  2. Tạo Migration đầu tiên.
  3. Seed dữ liệu Category và Product.
- **Blockers:** Không có.

### Nguyễn Chí Hoàng

- **Hôm qua:** Đã xây dựng trang Menu và hiển thị Category.
- **Hôm nay:**
  1. Xây dựng chức năng lọc món theo Category.
  2. Tạo chức năng tìm kiếm món theo tên.
  3. Kiểm tra kết quả tìm kiếm và lọc.
- **Blockers:** Không có.

---

## Thứ Năm, 19/06/2026

### Huỳnh Đăng Khoa

- **Hôm qua:** Đã hoàn thiện trang chủ và Responsive cơ bản.
- **Hôm nay:**
  1. Thiết kế giao diện Product Detail.
  2. Hiển thị hình ảnh và thông tin món ăn.
  3. Thiết kế khu vực giá và nút thêm vào giỏ hàng.
- **Blockers:** Không có.

### Nguyễn Phi Hùng

- **Hôm qua:** Đã hoàn thiện Admin Dashboard và phân quyền.
- **Hôm nay:**
  1. Xây dựng tìm kiếm nâng cao theo giá.
  2. Thêm bộ lọc theo Category.
  3. Thêm bộ lọc theo mức độ cay.
- **Blockers:** Không có.

### Ngô Nhựt Nam

- **Hôm qua:** Đã hoàn thiện phần Database và Seed Data.
- **Hôm nay:**
  1. Xây dựng Model Address.
  2. Tạo chức năng thêm địa chỉ giao hàng.
  3. Xây dựng chức năng chọn địa chỉ mặc định.
- **Blockers:** Không có.

---

## Thứ Sáu, 20/06/2026

### Huỳnh Đăng Khoa

- **Hôm qua:** Đã xây dựng giao diện Product Detail và khu vực thông tin món ăn.
- **Hôm nay:**
  1. Hoàn thiện Responsive cho Product Detail.
  2. Thiết kế khu vực đánh giá món ăn.
  3. Điều chỉnh giao diện nút Add to Cart.
- **Blockers:** Không có.

### Nguyễn Trọng Nghĩa

- **Hôm qua:** Đã hoàn thiện Database Model và Seed Data.
- **Hôm nay:**
  1. Xây dựng Model Review.
  2. Tạo chức năng lưu đánh giá.
  3. Thiết lập quan hệ Review - Product.
- **Blockers:** Không có.

### Ngô Nhựt Nam

- **Hôm qua:** Đã tạo Address Model và chức năng thêm địa chỉ.
- **Hôm nay:**
  1. Xây dựng chức năng sửa địa chỉ.
  2. Xây dựng chức năng xóa địa chỉ.
  3. Hiển thị danh sách địa chỉ của người dùng.
- **Blockers:** Không có.

---

## Thứ Hai, 23/06/2026

### Nguyễn Chí Hoàng

- **Hôm qua:** Đã hoàn thiện tìm kiếm, lọc Category và kiểm tra Menu.
- **Hôm nay:**
  1. Liên kết Menu với Product Detail.
  2. Xử lý chức năng Add to Cart từ Product Detail.
  3. Kiểm tra luồng Menu → Product Detail → Cart.
- **Blockers:** Không có.

### Phạm Thị Hồng Gấm

- **Hôm qua:** Chuẩn bị cấu trúc giao diện Cart.
- **Hôm nay:**
  1. Thiết kế giao diện Cart.
  2. Hiển thị danh sách sản phẩm trong Cart.
  3. Xử lý tăng và giảm số lượng sản phẩm.
- **Blockers:** Không có.

### Nguyễn Trọng Nghĩa

- **Hôm qua:** Đã xây dựng Review Model và chức năng lưu đánh giá.
- **Hôm nay:**
  1. Hoàn thiện logic kiểm tra Review.
  2. Kiểm tra dữ liệu Review trong Database.
  3. Tích hợp Review vào Product Detail.
- **Blockers:** Không có.

---

## Thứ Ba, 24/06/2026

### Phạm Thị Hồng Gấm

- **Hôm qua:** Đã xây dựng Cart UI và xử lý thay đổi số lượng.
- **Hôm nay:**
  1. Xử lý xóa sản phẩm khỏi Cart.
  2. Tính tổng tiền Cart.
  3. Hiển thị số lượng sản phẩm trên Navbar.
- **Blockers:** Không có.

### Nguyễn Trọng Nghĩa

- **Hôm qua:** Đã hoàn thiện Review và tích hợp vào Product Detail.
- **Hôm nay:**
  1. Xây dựng chức năng Checkout.
  2. Tạo Order và OrderItem từ Cart.
  3. Thiết lập transaction khi tạo Order.
- **Blockers:** Khi test Checkout xuất hiện lỗi `This SqlTransaction has completed; it is no longer usable`.

### Ngô Nhựt Nam

- **Hôm qua:** Đã hoàn thiện chức năng quản lý địa chỉ.
- **Hôm nay:**
  1. Cài đặt công thức Haversine.
  2. Tính khoảng cách giữa địa chỉ giao hàng và điểm xuất phát.
  3. Xây dựng logic tính phí giao hàng.
- **Blockers:** Không có.

---

## Thứ Tư, 25/06/2026

### Nguyễn Trọng Nghĩa

- **Hôm qua:** Đã xây dựng Checkout và phát hiện lỗi Transaction.
- **Hôm nay:**
  1. Xử lý lỗi Transaction khi Checkout.
  2. Kiểm tra việc tạo Order và OrderItem.
  3. Kiểm tra cập nhật tồn kho sau khi đặt hàng.
- **Blockers:** Đã xác định lỗi Rollback được gọi trên Transaction đã hoàn thành và tiến hành điều chỉnh xử lý Exception.

### Phạm Thị Hồng Gấm

- **Hôm qua:** Đã hoàn thiện Cart và tổng tiền.
- **Hôm nay:**
  1. Thiết kế giao diện Checkout.
  2. Hiển thị thông tin địa chỉ giao hàng.
  3. Hiển thị tổng tiền và phí giao hàng.
- **Blockers:** Không có.

### Nguyễn Phi Hùng

- **Hôm qua:** Đã hoàn thiện Advanced Search.
- **Hôm nay:**
  1. Xây dựng OrderStatusMachine.
  2. Khai báo các trạng thái của Order.
  3. Kiểm tra điều kiện chuyển trạng thái.
- **Blockers:** Không có.

---

## Thứ Năm, 26/06/2026

### Phạm Thị Hồng Gấm

- **Hôm qua:** Đã hoàn thiện giao diện Checkout.
- **Hôm nay:**
  1. Thiết kế giao diện Kitchen.
  2. Hiển thị danh sách đơn hàng mới.
  3. Tạo thao tác tiếp nhận đơn hàng cho Staff.
- **Blockers:** Không có.

### Ngô Nhựt Nam

- **Hôm qua:** Đã hoàn thiện tính khoảng cách và phí giao hàng.
- **Hôm nay:**
  1. Xây dựng Shipper Controller.
  2. Hiển thị danh sách đơn hàng sẵn sàng giao.
  3. Xử lý cập nhật trạng thái giao hàng.
- **Blockers:** Không có.

### Nguyễn Chí Hoàng

- **Hôm qua:** Đã hoàn thiện luồng Menu → Product Detail → Cart.
- **Hôm nay:**
  1. Xây dựng chức năng hủy đơn hàng.
  2. Kiểm tra điều kiện được phép hủy đơn.
  3. Cập nhật trạng thái đơn sau khi hủy.
- **Blockers:** Không có.

---

## Thứ Sáu, 27/06/2026 — Ngày cuối Sprint

### Huỳnh Đăng Khoa

- **Hôm qua:** Đã hoàn thiện giao diện chính của Customer và kiểm tra Responsive.
- **Hôm nay:**
  1. Sửa lỗi khoảng cách và đồng bộ giao diện giữa Menu, Cart và Checkout.
  2. Chuẩn bị giao diện và Demo luồng đặt món cho Sprint Review.
  3. Kiểm tra lại các màn hình Customer chính.
- **Blockers:** Một số thành phần cần điều chỉnh lại trên màn hình nhỏ.

### Nguyễn Phi Hùng

- **Hôm qua:** Đã hoàn thiện OrderStatusMachine và kiểm tra Authorization/Order Status.
- **Hôm nay:**
  1. Kiểm tra lại Authentication và quyền truy cập Admin, Staff, Shipper.
  2. Hỗ trợ xử lý các lỗi Backend còn lại.
  3. Chuẩn bị phần Backend cho Sprint Review.
- **Blockers:** Không có.

### Nguyễn Trọng Nghĩa

- **Hôm qua:** Đã xử lý lỗi Transaction và kiểm tra Checkout.
- **Hôm nay:**
  1. Kiểm tra tính toàn vẹn dữ liệu Order.
  2. Kiểm tra quan hệ Order - OrderItem.
  3. Kiểm tra tồn kho sau Checkout.
- **Blockers:** Không có.

### Ngô Nhựt Nam

- **Hôm qua:** Đã hoàn thiện Shipper Controller và cập nhật trạng thái giao hàng.
- **Hôm nay:**
  1. Kiểm tra chức năng Address.
  2. Kiểm tra công thức Delivery Fee.
  3. Kiểm tra luồng Shipper nhận và giao đơn.
- **Blockers:** Không có.

### Nguyễn Chí Hoàng

- **Hôm qua:** Đã hoàn thiện chức năng hủy đơn.
- **Hôm nay:**
  1. Kiểm tra lại Menu và Search.
  2. Kiểm tra lại Cart.
  3. Chuẩn bị luồng Customer Demo.
- **Blockers:** Không có.

### Phạm Thị Hồng Gấm

- **Hôm qua:** Đã hoàn thiện Kitchen UI và luồng tiếp nhận đơn.
- **Hôm nay:**
  1. Kiểm tra giao diện Kitchen.
  2. Kiểm tra hiển thị đơn hàng mới.
  3. Chuẩn bị phần Staff Demo.
- **Blockers:** Không có.

---
