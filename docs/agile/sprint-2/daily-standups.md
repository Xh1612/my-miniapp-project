# Daily Standups — Sprint 2

**Thời gian Sprint:** 31/07/2026 – 19/08/2026

**Team:** 6 thành viên

---

## Thứ Sáu, 31/07/2026

### Người tham gia
- Huỳnh Đăng Khoa
- Nguyễn Phi Hùng
- Phạm Thị Hồng Gấm

### Huỳnh Đăng Khoa

**Hôm qua làm gì:**
- Hoàn thiện các giao diện chính của Sprint 1.
- Kiểm tra giao diện Menu và Product Detail.
- Chuẩn bị các thành phần UI cần nâng cấp trong Sprint 2.

**Hôm nay sẽ làm gì:**
1. Rà soát giao diện Login/Register.
2. Xây dựng layout cho giao diện xác thực mới.
3. Chuẩn bị theme màu sắc và typography cho thương hiệu Hương Quê Việt.

**Blocker:** Không có.

### Nguyễn Phi Hùng

**Hôm qua làm gì:**
- Hoàn thiện Authentication và Authorization.
- Kiểm tra luồng Order và Order Status.
- Chuẩn bị các chức năng thanh toán cho Sprint 2.

**Hôm nay sẽ làm gì:**
1. Rà soát cấu trúc Authentication hiện tại.
2. Chuẩn bị tích hợp VNPay Sandbox.
3. Thiết kế luồng callback sau khi thanh toán VNPay.

**Blocker:** Cần kiểm tra thông tin kết nối VNPay Sandbox trước khi test end-to-end.

### Phạm Thị Hồng Gấm

**Hôm qua làm gì:**
- Hoàn thiện Cart và Checkout UI.
- Kiểm tra hiển thị Address.
- Kiểm tra giao diện Staff/Shipper.

**Hôm nay sẽ làm gì:**
1. Cải thiện giao diện Login.
2. Cải thiện giao diện Register.
3. Thiết kế trạng thái loading và thông báo cho Checkout.

**Blocker:** Không có.

---

## Thứ Hai, 03/08/2026

### Người tham gia
- Nguyễn Phi Hùng
- Nguyễn Trọng Nghĩa
- Ngô Nhựt Nam
- Nguyễn Chí Hoàng

### Nguyễn Phi Hùng

**Hôm qua làm gì:**
- Chuẩn bị cấu trúc VNPay.
- Kiểm tra Authentication.
- Thiết kế callback thanh toán.

**Hôm nay sẽ làm gì:**
1. Tích hợp chữ ký HMAC-SHA512 cho VNPay.
2. Xây dựng URL thanh toán VNPay.
3. Xử lý callback từ VNPay.

**Blocker:** Chưa test được đầy đủ nếu thông tin Sandbox chưa hoàn tất.

### Nguyễn Trọng Nghĩa

**Hôm qua làm gì:**
- Rà soát Model Order.
- Kiểm tra tồn kho.
- Chuẩn bị cho Coupon và Ingredient.

**Hôm nay sẽ làm gì:**
1. Thiết kế Model Coupon.
2. Tạo quan hệ Coupon với Order.
3. Tạo Migration cho Coupon.

**Blocker:** Cần thống nhất quy tắc giảm giá trước khi hoàn thiện Service.

### Ngô Nhựt Nam

**Hôm qua làm gì:**
- Kiểm tra DbContext.
- Rà soát Service layer.
- Chuẩn bị cấu trúc Inventory.

**Hôm nay sẽ làm gì:**
1. Xây dựng CouponService.
2. Xử lý kiểm tra mã giảm giá.
3. Tích hợp CouponService vào Checkout.

**Blocker:** Không có.

### Nguyễn Chí Hoàng

**Hôm qua làm gì:**
- Kiểm tra Menu.
- Kiểm tra Product Detail.
- Kiểm tra Cart integration.

**Hôm nay sẽ làm gì:**
1. Hiển thị Coupon trong Cart.
2. Thêm UI nhập mã giảm giá.
3. Hiển thị số tiền được giảm trước Checkout.

**Blocker:** Cần chờ API/Service Coupon ổn định để tích hợp UI.

---

## Thứ Ba, 04/08/2026

### Người tham gia
- Nguyễn Phi Hùng
- Nguyễn Trọng Nghĩa
- Ngô Nhựt Nam

### Nguyễn Phi Hùng

**Hôm qua làm gì:**
- Tích hợp HMAC-SHA512.
- Xây dựng URL thanh toán.
- Xử lý callback VNPay.

**Hôm nay sẽ làm gì:**
1. Hoàn thiện trạng thái thanh toán VNPay.
2. Kiểm tra chữ ký callback.
3. Xử lý trường hợp thanh toán thành công/thất bại.

**Blocker:** Không có.

### Nguyễn Trọng Nghĩa

**Hôm qua làm gì:**
- Tạo Model Coupon.
- Tạo quan hệ Coupon với Order.
- Tạo Migration.

**Hôm nay sẽ làm gì:**
1. Thiết kế Ingredient.
2. Thiết kế ProductIngredient.
3. Thiết kế InventoryLog.

**Blocker:** Cần xác định đơn vị tính của từng nguyên liệu.

### Ngô Nhựt Nam

**Hôm qua làm gì:**
- Xây dựng CouponService.
- Kiểm tra mã giảm giá.
- Tích hợp Coupon vào Checkout.

**Hôm nay sẽ làm gì:**
1. Xây dựng logic trừ tồn kho theo nguyên liệu.
2. Xử lý ProductIngredient.
3. Ghi InventoryLog khi phát sinh giao dịch.

**Blocker:** Cần kiểm tra các Product chưa có công thức nguyên liệu.

---

## Thứ Tư, 05/08/2026

### Người tham gia
- Huỳnh Đăng Khoa
- Nguyễn Phi Hùng
- Phạm Thị Hồng Gấm
- Nguyễn Chí Hoàng

### Huỳnh Đăng Khoa

**Hôm qua làm gì:**
- Rà soát giao diện xác thực.
- Chuẩn bị theme.
- Kiểm tra UI Checkout.

**Hôm nay sẽ làm gì:**
1. Thiết kế trang thanh toán VNPay.
2. Thiết kế thông báo trạng thái thanh toán.
3. Responsive giao diện Checkout.

**Blocker:** Không có.

### Nguyễn Phi Hùng

**Hôm qua làm gì:**
- Hoàn thiện callback VNPay.
- Kiểm tra chữ ký.
- Xử lý kết quả thanh toán.

**Hôm nay sẽ làm gì:**
1. Tích hợp VNPay vào Order Flow.
2. Xử lý trạng thái thanh toán trong Order.
3. Kiểm tra trường hợp người dùng hủy thanh toán.

**Blocker:** Không có.

### Phạm Thị Hồng Gấm

**Hôm qua làm gì:**
- Cải thiện Login.
- Cải thiện Register.
- Chuẩn bị UI thông báo.

**Hôm nay sẽ làm gì:**
1. Xây dựng UI Coupon.
2. Hiển thị thông báo Coupon hợp lệ/không hợp lệ.
3. Cải thiện giao diện Order Summary.

**Blocker:** Không có.

### Nguyễn Chí Hoàng

**Hôm qua làm gì:**
- Tích hợp Coupon vào Cart.
- Hiển thị số tiền giảm.
- Kiểm tra Cart trước Checkout.

**Hôm nay sẽ làm gì:**
1. Test Coupon với nhiều mức giá.
2. Test Coupon hết hạn.
3. Test Coupon không tồn tại.

**Blocker:** Không có.

---

## Thứ Năm, 06/08/2026

### Người tham gia
- Nguyễn Trọng Nghĩa
- Ngô Nhựt Nam
- Nguyễn Phi Hùng

### Nguyễn Trọng Nghĩa

**Hôm qua làm gì:**
- Thiết kế Ingredient.
- Thiết kế ProductIngredient.
- Thiết kế InventoryLog.

**Hôm nay sẽ làm gì:**
1. Tạo Migration cho Ingredient.
2. Seed dữ liệu nguyên liệu mẫu.
3. Kiểm tra quan hệ Product–Ingredient.

**Blocker:** Không có.

### Ngô Nhựt Nam

**Hôm qua làm gì:**
- Xây dựng tồn kho theo nguyên liệu.
- Xử lý ProductIngredient.
- Ghi InventoryLog.

**Hôm nay sẽ làm gì:**
1. Hoàn thiện InventoryService.
2. Xử lý trường hợp sản phẩm chưa có công thức.
3. Tích hợp InventoryService vào Checkout.

**Blocker:** Cần đảm bảo transaction không bị ảnh hưởng khi chuyển sang tồn kho theo nguyên liệu.

### Nguyễn Phi Hùng

**Hôm qua làm gì:**
- Tích hợp VNPay vào Order.
- Xử lý trạng thái thanh toán.
- Kiểm tra hủy thanh toán.

**Hôm nay sẽ làm gì:**
1. Test VNPay Sandbox end-to-end.
2. Xử lý ReturnUrl.
3. Kiểm tra tính toàn vẹn dữ liệu Order sau thanh toán.

**Blocker:** Không có.

---

## Thứ Sáu, 07/08/2026

### Người tham gia
- Nguyễn Phi Hùng
- Ngô Nhựt Nam
- Phạm Thị Hồng Gấm

### Nguyễn Phi Hùng

**Hôm qua làm gì:**
- Test VNPay Sandbox.
- Xử lý ReturnUrl.
- Kiểm tra Order sau thanh toán.

**Hôm nay sẽ làm gì:**
1. Hoàn thiện VNPay Service.
2. Xử lý các trường hợp VNPay trả kết quả lỗi.
3. Kiểm tra bảo mật chữ ký VNPay.

**Blocker:** Không có.

### Ngô Nhựt Nam

**Hôm qua làm gì:**
- Hoàn thiện InventoryService.
- Xử lý sản phẩm chưa có công thức.
- Tích hợp Inventory vào Checkout.

**Hôm nay sẽ làm gì:**
1. Test trừ tồn kho theo nguyên liệu.
2. Test trường hợp thiếu nguyên liệu.
3. Kiểm tra InventoryLog sau Checkout.

**Blocker:** Không có.

### Phạm Thị Hồng Gấm

**Hôm qua làm gì:**
- Hoàn thiện Coupon UI.
- Xử lý thông báo Coupon.
- Cải thiện Order Summary.

**Hôm nay sẽ làm gì:**
1. Thiết kế UI trạng thái thanh toán.
2. Thiết kế trang Payment Result.
3. Cải thiện giao diện Order Detail.

**Blocker:** Không có.

---

## Thứ Hai, 10/08/2026

### Người tham gia
- Nguyễn Phi Hùng
- Nguyễn Trọng Nghĩa
- Ngô Nhựt Nam
- Phạm Thị Hồng Gấm

### Nguyễn Phi Hùng

**Hôm qua làm gì:**
- Hoàn thiện VNPay.
- Kiểm tra lỗi thanh toán.
- Kiểm tra chữ ký.

**Hôm nay sẽ làm gì:**
1. Xây dựng SignalR Hub cho Order.
2. Phát sự kiện khi trạng thái đơn thay đổi.
3. Kết nối Staff/Shipper với SignalR.

**Blocker:** Không có.

### Nguyễn Trọng Nghĩa

**Hôm qua làm gì:**
- Kiểm tra Inventory.
- Kiểm tra thiếu nguyên liệu.
- Kiểm tra InventoryLog.

**Hôm nay sẽ làm gì:**
1. Rà soát Model Order Status.
2. Kiểm tra các trạng thái hợp lệ.
3. Kiểm tra dữ liệu Order History.

**Blocker:** Không có.

### Ngô Nhựt Nam

**Hôm qua làm gì:**
- Test Inventory.
- Test thiếu nguyên liệu.
- Kiểm tra InventoryLog.

**Hôm nay sẽ làm gì:**
1. Tích hợp SignalR vào Order Service.
2. Gửi notification khi Order thay đổi trạng thái.
3. Kiểm tra kết nối Hub.

**Blocker:** Không có.

### Phạm Thị Hồng Gấm

**Hôm qua làm gì:**
- Thiết kế Payment Result.
- Cải thiện Order Detail.
- Hoàn thiện UI trạng thái thanh toán.

**Hôm nay sẽ làm gì:**
1. Hiển thị trạng thái Order realtime.
2. Thêm notification khi đơn thay đổi.
3. Cải thiện giao diện Order History.

**Blocker:** Không có.

---

## Thứ Ba, 11/08/2026

### Người tham gia
- Nguyễn Phi Hùng
- Ngô Nhựt Nam
- Nguyễn Chí Hoàng

### Nguyễn Phi Hùng

**Hôm qua làm gì:**
- Xây dựng SignalR Hub.
- Phát sự kiện Order.
- Kết nối Staff/Shipper.

**Hôm nay sẽ làm gì:**
1. Kiểm tra SignalR với nhiều client.
2. Xử lý reconnect.
3. Kiểm tra quyền truy cập Hub.

**Blocker:** Cần kiểm tra trường hợp người dùng mất kết nối rồi truy cập lại.

### Ngô Nhựt Nam

**Hôm qua làm gì:**
- Tích hợp SignalR vào Service.
- Gửi notification.
- Kiểm tra Hub.

**Hôm nay sẽ làm gì:**
1. Tích hợp EmailService.
2. Tạo MockSmsService.
3. Tạo NotificationService dùng chung.

**Blocker:** Không có.

### Nguyễn Chí Hoàng

**Hôm qua làm gì:**
- Kiểm tra Product.
- Kiểm tra Order History.
- Kiểm tra UI realtime.

**Hôm nay sẽ làm gì:**
1. Test trạng thái Order realtime.
2. Test notification khi Staff cập nhật đơn.
3. Test notification khi Shipper cập nhật đơn.

**Blocker:** Không có.

---

## Thứ Tư, 12/08/2026

### Người tham gia
- Nguyễn Phi Hùng
- Nguyễn Chí Hoàng
- Phạm Thị Hồng Gấm

### Nguyễn Phi Hùng

**Hôm qua làm gì:**
- Kiểm tra SignalR nhiều client.
- Xử lý reconnect.
- Kiểm tra quyền Hub.

**Hôm nay sẽ làm gì:**
1. Hoàn thiện Order Notification.
2. Tích hợp notification vào StaffController.
3. Tích hợp notification vào ShipperController.

**Blocker:** Cần tránh tạo notification trùng khi trạng thái được cập nhật nhiều lần.

### Nguyễn Chí Hoàng

**Hôm qua làm gì:**
- Test Order realtime.
- Test Staff notification.
- Test Shipper notification.

**Hôm nay sẽ làm gì:**
1. Xây dựng trang lịch sử đơn hàng khách hàng.
2. Thêm bộ lọc trạng thái đơn.
3. Thêm chức năng xem chi tiết đơn cũ.

**Blocker:** Không có.

### Phạm Thị Hồng Gấm

**Hôm qua làm gì:**
- Hiển thị Order realtime.
- Notification UI.
- Order History UI.

**Hôm nay sẽ làm gì:**
1. Hoàn thiện giao diện Order History.
2. Thiết kế trạng thái đơn hàng bằng Timeline.
3. Responsive trang Order History.

**Blocker:** Không có.

---

## Thứ Năm, 13/08/2026

### Người tham gia
- Nguyễn Trọng Nghĩa
- Nguyễn Phi Hùng
- Ngô Nhựt Nam

### Nguyễn Trọng Nghĩa

**Hôm qua làm gì:**
- Rà soát Order.
- Kiểm tra Order History.
- Kiểm tra dữ liệu trạng thái.

**Hôm nay sẽ làm gì:**
1. Xây dựng quản lý Category trong Admin.
2. Thêm chức năng tạo Category.
3. Thêm chức năng sửa Category.

**Blocker:** Không có.

### Nguyễn Phi Hùng

**Hôm qua làm gì:**
- Hoàn thiện Notification.
- Tích hợp StaffController.
- Tích hợp ShipperController.

**Hôm nay sẽ làm gì:**
1. Kiểm tra Authorization trong Admin.
2. Kiểm tra quyền quản lý Category.
3. Kiểm tra quyền quản lý Product.

**Blocker:** Không có.

### Ngô Nhựt Nam

**Hôm qua làm gì:**
- Hoàn thiện EmailService.
- Hoàn thiện MockSmsService.
- Hoàn thiện NotificationService.

**Hôm nay sẽ làm gì:**
1. Xây dựng CRUD Product trong Admin.
2. Tích hợp upload ảnh sản phẩm.
3. Xử lý xóa mềm Product.

**Blocker:** Cần kiểm tra trường hợp Product đã xuất hiện trong Order.

---

## Thứ Sáu, 14/08/2026

### Người tham gia
- Nguyễn Trọng Nghĩa
- Ngô Nhựt Nam
- Nguyễn Phi Hùng
- Huỳnh Đăng Khoa

### Nguyễn Trọng Nghĩa

**Hôm qua làm gì:**
- Xây dựng Category CRUD.
- Thêm Category.
- Sửa Category.

**Hôm nay sẽ làm gì:**
1. Hoàn thiện xóa Category.
2. Kiểm tra Category có Product liên quan.
3. Test Category CRUD.

**Blocker:** Không cho phép xóa Category nếu dữ liệu liên quan chưa được xử lý phù hợp.

### Ngô Nhựt Nam

**Hôm qua làm gì:**
- Xây dựng Product CRUD.
- Upload ảnh.
- Xử lý xóa mềm.

**Hôm nay sẽ làm gì:**
1. Hoàn thiện Product Management.
2. Kiểm tra Product với Category.
3. Kiểm tra Product với Ingredient.

**Blocker:** Không có.

### Nguyễn Phi Hùng

**Hôm qua làm gì:**
- Kiểm tra Authorization.
- Kiểm tra quyền Category.
- Kiểm tra quyền Product.

**Hôm nay sẽ làm gì:**
1. Xây dựng quản lý User.
2. Phân quyền User theo Role.
3. Kiểm tra quyền truy cập Admin/User.

**Blocker:** Không có.

### Huỳnh Đăng Khoa

**Hôm qua làm gì:**
- Chuẩn bị UI thương hiệu.
- Kiểm tra các trang khách hàng.
- Chuẩn bị theme CSS.

**Hôm nay sẽ làm gì:**
1. Xây dựng `theme.css`.
2. Áp dụng màu sắc thương hiệu Hương Quê Việt.
3. Cải thiện Header và Footer.

**Blocker:** Không có.

---

## Thứ Hai, 17/08/2026

### Người tham gia
- Nguyễn Phi Hùng
- Nguyễn Trọng Nghĩa
- Ngô Nhựt Nam
- Huỳnh Đăng Khoa

### Nguyễn Phi Hùng

**Hôm qua làm gì:**
- Xây dựng User Management.
- Phân quyền User.
- Kiểm tra Authorization.

**Hôm nay sẽ làm gì:**
1. Hoàn thiện User Management.
2. Thêm chức năng khóa/mở khóa tài khoản.
3. Kiểm tra phân quyền Admin/Staff/Shipper.

**Blocker:** Không có.

### Nguyễn Trọng Nghĩa

**Hôm qua làm gì:**
- Hoàn thiện Category.
- Kiểm tra quan hệ Category.
- Test Category CRUD.

**Hôm nay sẽ làm gì:**
1. Rà soát Ingredient Management.
2. Kiểm tra tồn kho nguyên liệu trong Admin.
3. Chuẩn bị dữ liệu cho thống kê.

**Blocker:** Không có.

### Ngô Nhựt Nam

**Hôm qua làm gì:**
- Hoàn thiện Product Management.
- Kiểm tra Product–Category.
- Kiểm tra Product–Ingredient.

**Hôm nay sẽ làm gì:**
1. Xây dựng Dashboard thống kê.
2. Chuẩn bị dữ liệu doanh thu.
3. Tích hợp Chart.js.

**Blocker:** Không có.

### Huỳnh Đăng Khoa

**Hôm qua làm gì:**
- Xây dựng theme.css.
- Áp dụng màu thương hiệu.
- Cải thiện Header/Footer.

**Hôm nay sẽ làm gì:**
1. Áp dụng theme cho trang Home.
2. Áp dụng theme cho Menu.
3. Áp dụng theme cho Product Detail.

**Blocker:** Cần đảm bảo CSS mới không ảnh hưởng layout cũ.

---

## Thứ Ba, 18/08/2026

### Người tham gia
- Nguyễn Phi Hùng
- Ngô Nhựt Nam
- Nguyễn Chí Hoàng
- Phạm Thị Hồng Gấm

### Nguyễn Phi Hùng

**Hôm qua làm gì:**
- Hoàn thiện User Management.
- Khóa/mở khóa tài khoản.
- Kiểm tra Role.

**Hôm nay sẽ làm gì:**
1. Thiết kế JWT Authentication cho API.
2. Cấu hình JWT Bearer.
3. Tạo endpoint API đầu tiên.

**Blocker:** Cần đảm bảo JWT không ảnh hưởng Authentication bằng Cookie của website.

### Ngô Nhựt Nam

**Hôm qua làm gì:**
- Xây dựng Dashboard.
- Chuẩn bị dữ liệu doanh thu.
- Tích hợp Chart.js.

**Hôm nay sẽ làm gì:**
1. Hoàn thiện biểu đồ doanh thu.
2. Thêm thống kê số lượng đơn hàng.
3. Kiểm tra dữ liệu thống kê theo thời gian.

**Blocker:** Không có.

### Nguyễn Chí Hoàng

**Hôm qua làm gì:**
- Kiểm tra Order History.
- Kiểm tra Product.
- Kiểm tra các luồng khách hàng.

**Hôm nay sẽ làm gì:**
1. Xây dựng Unit Test cho CouponService.
2. Kiểm thử Coupon hợp lệ.
3. Kiểm thử Coupon không hợp lệ/hết hạn.

**Blocker:** Không có.

### Phạm Thị Hồng Gấm

**Hôm qua làm gì:**
- Cải thiện UI Home.
- Cải thiện UI Menu.
- Cải thiện Product Detail.

**Hôm nay sẽ làm gì:**
1. Áp dụng theme cho Cart.
2. Áp dụng theme cho Checkout.
3. Áp dụng theme cho Order History.

**Blocker:** Không có.

---

## Thứ Tư, 19/08/2026 — Ngày cuối Sprint

### Người tham gia
- Huỳnh Đăng Khoa
- Nguyễn Phi Hùng
- Nguyễn Chí Hoàng
- Phạm Thị Hồng Gấm

### Huỳnh Đăng Khoa

**Hôm qua làm gì:**
- Áp dụng theme cho các trang khách hàng.
- Kiểm tra responsive.
- Rà soát giao diện toàn hệ thống.

**Hôm nay sẽ làm gì:**
1. Kiểm tra UI toàn bộ website.
2. Sửa các lỗi giao diện còn lại.
3. Chuẩn bị giao diện cho Sprint Review.

**Blocker:** Không có.

### Nguyễn Phi Hùng

**Hôm qua làm gì:**
- Thiết kế JWT.
- Cấu hình JWT Bearer.
- Tạo API endpoint.

**Hôm nay sẽ làm gì:**
1. Hoàn thiện JWT API.
2. Kiểm tra Cookie Authentication và JWT hoạt động song song.
3. Kiểm thử Authorization của API.

**Blocker:** Cần kiểm tra lại toàn bộ luồng đăng nhập sau khi thêm JWT.

### Nguyễn Chí Hoàng

**Hôm qua làm gì:**
- Viết Unit Test cho CouponService.
- Test Coupon hợp lệ.
- Test Coupon lỗi.

**Hôm nay sẽ làm gì:**
1. Viết Unit Test cho OrderStatusMachine.
2. Kiểm tra các trạng thái hợp lệ.
3. Kiểm tra các trường hợp chuyển trạng thái không hợp lệ.

**Blocker:** Không có.

### Phạm Thị Hồng Gấm

**Hôm qua làm gì:**
- Áp dụng theme cho Cart.
- Áp dụng theme cho Checkout.
- Áp dụng theme cho Order History.

**Hôm nay sẽ làm gì:**
1. Kiểm tra responsive toàn bộ giao diện khách hàng.
2. Sửa lỗi UI phát hiện trong quá trình kiểm thử.
3. Chuẩn bị screenshot/demo cho Sprint Review.

**Blocker:** Không có.

---

# Tổng kết Sprint 2

Sprint 2 tập trung hoàn thiện các chức năng nâng cao của hệ thống:

- VNPay Sandbox.
- Coupon.
- Inventory theo nguyên liệu.
- SignalR.
- Email/SMS Notification.
- Order History.
- Category/Product/User Management.
- Dashboard và Chart.js.
- JWT API.
- Unit Test.
- Giao diện thương hiệu Hương Quê Việt.

Các chức năng sau Sprint 2 sẽ được kiểm thử tổng thể trước khi thực hiện Sprint Review và Sprint Retrospective.
