# Daily Standups — Sprint 1

> Vì team chỉ có 1 thành viên, standup được ghi lại dưới dạng nhật ký cá nhân cuối mỗi ngày làm việc, vẫn theo đúng 3 câu hỏi chuẩn của Scrum để duy trì kỷ luật theo dõi tiến độ và phát hiện sớm điểm nghẽn (blocker).

## Thứ Hai, 16/06/2026
- **Hôm qua làm gì:** (Ngày đầu Sprint)
- **Hôm nay làm gì:** Khởi tạo project ASP.NET Core MVC (.NET 8) với Individual Accounts; tạo Area "Admin" và layout quản trị riêng.
- **Khó khăn/Blocker:** Không có.

## Thứ Ba, 17/06/2026
- **Hôm qua làm gì:** Setup project + Area Admin.
- **Hôm nay làm gì:** Thiết kế Model (ApplicationUser, Category, Product, Order, OrderItem), tạo DbContext, chạy Migration đầu tiên, seed dữ liệu mẫu qua HasData.
- **Khó khăn/Blocker:** Không có — quyết định seed sẵn dữ liệu mẫu ngay trong Migration giúp tiết kiệm thời gian test so với việc gõ tay SQL mỗi lần.

## Thứ Tư, 18/06/2026
- **Hôm qua làm gì:** Model + DbContext + seed data.
- **Hôm nay làm gì:** Trang chủ (món nổi bật/mới nhất), trang thực đơn với lọc danh mục và tìm kiếm đơn giản.
- **Khó khăn/Blocker:** Không có.

## Thứ Năm, 19/06/2026
- **Hôm qua làm gì:** Trang chủ + thực đơn + tìm kiếm.
- **Hôm nay làm gì:** Tìm kiếm nâng cao; trang chi tiết sản phẩm kèm đánh giá.
- **Khó khăn/Blocker:** Gặp lỗi `InvalidOperationException: No service for type UserManager<IdentityUser>` khi chạy F5 — nguyên nhân do file `_LoginPartial.cshtml` mặc định vẫn tham chiếu kiểu `IdentityUser` gốc trong khi `Program.cs` đã đổi sang `ApplicationUser` tùy biến. Đã sửa bằng cách cập nhật lại 2 dòng `@inject` trong `_LoginPartial.cshtml`. **Bài học:** cần rà lại toàn bộ file do Identity tự sinh mỗi khi đổi kiểu User tùy biến.

## Thứ Sáu, 20/06/2026
- **Hôm qua làm gì:** Fix lỗi UserManager, hoàn thành trang chi tiết sản phẩm + đánh giá.
- **Hôm nay làm gì:** Giỏ hàng (Session-based) và View Component hiển thị số lượng trên Navbar.
- **Khó khăn/Blocker:** Không có — đây là lần đầu dùng View Component, mất thêm thời gian đọc tài liệu để hiểu đúng khác biệt so với Partial View trước khi cài đặt.

## Thứ Hai, 23/06/2026
- **Hôm qua làm gì:** Giỏ hàng + View Component.
- **Hôm nay làm gì:** Chức năng quản lý địa chỉ giao hàng, cài đặt công thức Haversine tính khoảng cách.
- **Khó khăn/Blocker:** Sau khi bấm "Lưu địa chỉ", gặp lỗi `View 'Index' was not found` — do quên tạo file `Views/Addresses/Index.cshtml` dù Controller đã có action `Index()` hoàn chỉnh. Bổ sung file View còn thiếu, lỗi hết ngay. **Bài học:** viết Controller xong cần rà lại đủ toàn bộ action có action nào thiếu View tương ứng hay chưa trước khi chuyển việc khác.

## Thứ Ba, 24/06/2026
- **Hôm qua làm gì:** Địa chỉ giao hàng + Haversine.
- **Hôm nay làm gì:** Action đặt hàng (Checkout) có transaction kiểm tra và trừ tồn kho.
- **Khó khăn/Blocker:** Khi test đặt hàng bị lỗi `InvalidOperationException: This SqlTransaction has completed; it is no longer usable` — mất khá nhiều thời gian mới nhận ra đây chỉ là lỗi **thứ cấp** (transaction tự đóng do lỗi gốc phía trước, rồi lệnh `RollbackAsync()` gọi lại vào transaction đã đóng gây lỗi chồng lỗi), che mất thông báo lỗi thật sự. Bọc `RollbackAsync()` trong khối try/catch riêng để không nuốt mất lỗi gốc, đồng thời hiển thị lỗi thật ra giao diện qua TempData. **Bài học quan trọng:** thông báo lỗi hiển thị đầu tiên không phải lúc nào cũng là nguyên nhân gốc — cần luôn truy ngược chuỗi exception.

## Thứ Tư, 25/06/2026
- **Hôm qua làm gì:** Fix lỗi transaction, hoàn thiện action Checkout.
- **Hôm nay làm gì:** Cài đặt `OrderStatusMachine` kiểm soát chuyển trạng thái đơn hàng; bắt đầu `StaffController` và `ShipperController`.
- **Khó khăn/Blocker:** Không có.

## Thứ Năm, 26/06/2026
- **Hôm qua làm gì:** OrderStatusMachine + Staff/Shipper Controller.
- **Hôm nay làm gì:** Hoàn thiện View cho Staff/Shipper; test đăng nhập đa vai trò.
- **Khó khăn/Blocker:** Vào `/Admin/Staff` thấy đúng navbar nhưng toàn bộ liên kết bấm không phản ứng gì. Nguyên nhân: `Areas/Admin/Views/` chưa có file `_ViewImports.cshtml` riêng, khiến Tag Helper (`asp-controller`, `asp-action`...) không được kích hoạt trong Area — file `_ViewImports.cshtml` ở `Views/` gốc không tự áp dụng sang nhánh thư mục Area khác. Bổ sung `_ViewImports.cshtml` cho đúng thư mục Area, lỗi hết ngay. **Bài học:** Area là một nhánh thư mục độc lập gần như hoàn toàn — mọi file cấu hình cấp thư mục (`_ViewStart`, `_ViewImports`) đều cần có bản riêng, không kế thừa từ gốc.

## Thứ Sáu, 27/06/2026 (Ngày cuối Sprint)
- **Hôm qua làm gì:** Fix lỗi Tag Helper trong Area.
- **Hôm nay làm gì:** Kiểm thử toàn bộ luồng end-to-end (khách đặt hàng → Staff xác nhận → Shipper giao); dọn dẹp code, chuẩn bị Sprint Review.
- **Khó khăn/Blocker:** Không có — mọi task trong Sprint Backlog đã hoàn thành đúng hạn.
