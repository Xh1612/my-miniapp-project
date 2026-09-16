# Sprint Review — Sprint 2

**Ngày:** 11/07/2026
**Người tham dự:** Sinh viên thực hiện (Product Owner/Developer), Giảng viên hướng dẫn

## Sprint Goal đã đạt được?

✅ **Đạt.** Toàn bộ phân hệ quản trị đã hoàn chỉnh, thanh toán trực tuyến và cập nhật thời gian thực đã hoạt động, và cả ba tính năng mở rộng (JWT, Unit Test, đa ngôn ngữ) đều đã tích hợp thành công mà không ảnh hưởng đến các chức năng đã hoàn thành ở Sprint 1.

## Các tính năng đã hoàn thành (Done)

- Đăng ký yêu cầu họ tên/SĐT + giao diện Đăng nhập/Đăng ký theo thương hiệu (US-18, US-19)
- Thanh toán VNPay + Mã giảm giá (US-15, US-16)
- Tồn kho theo nguyên liệu (US-27)
- Cập nhật trạng thái thời gian thực qua SignalR (US-13)
- Thông báo Email/SMS (US-17)
- Lịch sử đơn hàng cho Staff/Shipper (US-23)
- Quản lý danh mục, sản phẩm (kèm upload ảnh), người dùng (US-24, US-25, US-26)
- Thống kê báo cáo dạng bảng + biểu đồ (US-28)
- Giao diện thương hiệu riêng cho khách hàng (US-32)
- API xác thực JWT, Unit Test, đa ngôn ngữ (US-29, US-30, US-31)

## Demo trực tiếp

Đã demo trực tiếp: đặt hàng có áp mã giảm giá và thanh toán qua VNPay Sandbox; mở song song 2 tab để chứng minh trạng thái đơn cập nhật tức thời không cần tải lại trang; đăng nhập Admin thao tác đầy đủ CRUD danh mục/sản phẩm kèm upload ảnh thật; xem trang thống kê có biểu đồ; gọi thử API qua Postman để lấy JWT token và truy vấn đơn hàng cá nhân.

## Phản hồi từ giảng viên/khách hàng

- Đánh giá cao việc hệ thống có transaction an toàn xuyên suốt và có cả kiểm thử tự động, không chỉ dừng ở mức "chạy được".
- Góp ý: nên có ghi chú rõ trong báo cáo về giới hạn hiện tại (một cửa hàng, SMS mô phỏng) để thể hiện sự hiểu biết chủ động về phạm vi, không phải thiếu sót không nhận ra.
- Góp ý: phần thống kê có thể mở rộng thêm nếu còn thời gian, nhưng ở mức hiện tại đã đáp ứng đủ yêu cầu.

## Chưa làm được / Ghi nhận cho Product Backlog tương lai (ngoài phạm vi đồ án)

- Hỗ trợ đa cửa hàng/đa chi nhánh
- Lưu trữ ảnh trên dịch vụ đám mây thay vì máy chủ ứng dụng
- Tích hợp SMS thật qua nhà mạng
- Ứng dụng di động thực thụ (hiện chỉ có API nền tảng)
