# Daily Standups — Sprint 2

## Thứ Hai, 30/06/2026
- **Hôm qua làm gì:** (Ngày đầu Sprint 2)
- **Hôm nay làm gì:** Scaffold lại trang Đăng nhập/Đăng ký thành file thật trong project; bổ sung bắt buộc họ tên + số điện thoại khi đăng ký; đăng ký sớm tài khoản Sandbox VNPay (dự kiến mất vài ngày nhận phản hồi nên làm trước).
- **Khó khăn/Blocker:** Ban đầu quên rằng trang Register không tự có sẵn trong project (khác Login) — phải scaffold lại đúng cách qua "Add New Scaffolded Item" và tick chọn đúng mục Register mới ra file thật.

## Thứ Ba, 01/07/2026
- **Hôm qua làm gì:** Trang Đăng nhập/Đăng ký + đăng ký Sandbox VNPay.
- **Hôm nay làm gì:** Thiết kế lại giao diện Đăng nhập/Đăng ký theo đúng theme thương hiệu (bỏ phần "External logins" mặc định không dùng tới).
- **Khó khăn/Blocker:** Không có.

## Thứ Tư, 02/07/2026
- **Hôm qua làm gì:** Style trang Đăng nhập/Đăng ký.
- **Hôm nay làm gì:** Tích hợp chữ ký số HMAC-SHA512 và luồng tạo URL thanh toán VNPay.
- **Khó khăn/Blocker:** Vẫn đang chờ email cấp `TmnCode`/`HashSecret` từ VNPay — tạm thời code song song phần logic ký số dựa trên tài liệu, chưa test được đầu-cuối.

## Thứ Năm, 03/07/2026
- **Hôm qua làm gì:** Logic tạo URL thanh toán VNPay.
- **Hôm nay làm gì:** Đã nhận được thông tin kết nối VNPay, test thành công luồng thanh toán qua Sandbox; làm tiếp mã giảm giá (Coupon).
- **Khó khăn/Blocker:** Không có.

## Thứ Sáu, 04/07/2026
- **Hôm qua làm gì:** VNPay hoàn tất + Coupon.
- **Hôm nay làm gì:** Nâng cấp cơ chế tồn kho từ trừ theo món sang trừ theo nguyên liệu (Ingredient, ProductIngredient, InventoryLog), có dự phòng cho sản phẩm chưa cấu hình công thức.
- **Khó khăn/Blocker:** Không có.

## Thứ Hai, 07/07/2026
- **Hôm qua làm gì:** Tồn kho theo nguyên liệu.
- **Hôm nay làm gì:** SignalR cập nhật trạng thái thời gian thực; bắt đầu tích hợp thông báo Email/SMS.
- **Khó khăn/Blocker:** Sau khi thêm `INotificationService` vào `OrdersController`, project **không build được** — do mới khai báo sử dụng interface này trong Controller nhưng chưa tạo class hiện thực tương ứng (EmailService, MockSmsService, NotificationService). Bổ sung đủ 3 Service còn thiếu, build lại thành công. **Bài học:** khi thêm 1 dependency mới vào constructor, cần tạo và đăng ký Service tương ứng ngay trong cùng lượt thay đổi, tránh để project ở trạng thái không build được qua đêm.

## Thứ Ba, 08/07/2026
- **Hôm qua làm gì:** Fix lỗi thiếu Service, hoàn thiện thông báo Email/SMS.
- **Hôm nay làm gì:** Thêm thông báo khi đổi trạng thái đơn (Staff/Shipper); trang Lịch sử đơn hàng cho 2 vai trò này.
- **Khó khăn/Blocker:** Gặp lỗi biên dịch `CS0136: A local variable named 'user' cannot be declared in this scope` trong `StaffController.Advance()` — do dán đoạn code gửi thông báo **2 lần** vào cùng một hàm (một lần thêm thủ công trước đó, một lần thêm lại theo hướng dẫn mới mà không để ý đoạn cũ vẫn còn). Xóa khối trùng lặp, giữ lại đúng 1 lần gọi. **Bài học:** trước khi dán thêm code mới vào 1 hàm đã tồn tại, nên đọc lướt lại toàn bộ hàm đó để chắc chắn không có đoạn tương tự đã có sẵn.

## Thứ Tư, 09/07/2026
- **Hôm qua làm gì:** Fix lỗi trùng code, Lịch sử đơn hàng.
- **Hôm nay làm gì:** Quản lý danh mục (CRUD); bắt đầu quản lý sản phẩm đầy đủ kèm upload ảnh.
- **Khó khăn/Blocker:** Không có.

## Thứ Năm, 10/07/2026
- **Hôm qua làm gì:** Danh mục + bắt đầu sản phẩm.
- **Hôm nay làm gì:** Hoàn thiện quản lý sản phẩm (xóa mềm khi đã có đơn hàng liên quan); quản lý người dùng; trang thống kê có Chart.js.
- **Khó khăn/Blocker:** Không có.

## Thứ Sáu, 11/07/2026 (Ngày cuối Sprint)
- **Hôm qua làm gì:** Sản phẩm + người dùng + thống kê.
- **Hôm nay làm gì:** Thiết kế giao diện thương hiệu riêng (theme.css) áp dụng toàn bộ trang khách hàng; API JWT; Unit Test cho CouponService/OrderStatusMachine; cấu hình đa ngôn ngữ; hoàn tất viết báo cáo. Kiểm thử lại toàn bộ hệ thống để chuẩn bị Sprint Review.
- **Khó khăn/Blocker:** Ban đầu lo ngại việc thêm JWT sẽ phá vỡ cơ chế đăng nhập cookie hiện có của toàn bộ trang web — đã xử lý bằng cách gọi `AddAuthentication()` không ép buộc scheme mặc định, và chỉ định tường minh `AuthenticationSchemes` ở từng endpoint API cần JWT, giữ nguyên `[Authorize]` trơn cho các phần còn lại chạy bằng cookie như cũ. Đã kiểm tra lại toàn bộ luồng web sau khi thêm JWT, xác nhận không bị ảnh hưởng.
