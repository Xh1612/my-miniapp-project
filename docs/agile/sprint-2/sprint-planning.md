# Sprint 2 Planning

**Thời gian:** 30/06/2026 – 11/07/2026 (2 tuần)
**Team:** 1 thành viên (Product Owner kiêm Scrum Master kiêm Developer)

## Sprint Goal

> Hoàn thiện toàn bộ phân hệ quản trị (danh mục, sản phẩm, người dùng, nguyên liệu, thống kê), bổ sung thanh toán trực tuyến và cập nhật thời gian thực để nâng trải nghiệm khách hàng lên mức hoàn chỉnh, đồng thời tích hợp các tính năng mở rộng (JWT, Unit Test, đa ngôn ngữ) để tăng chiều sâu kỹ thuật của sản phẩm trước khi báo cáo cuối kỳ.

## Task được kéo từ Product Backlog vào Sprint này

| Task | User Story liên quan | Ước lượng | Người phụ trách |
|---|---|---|---|
| Đăng ký bắt buộc họ tên + SĐT; thiết kế lại trang Đăng nhập/Đăng ký theo thương hiệu | US-18, US-19 | 1 ngày | Sinh viên thực hiện |
| Tích hợp thanh toán VNPay (Sandbox) | US-16 | 1.5 ngày | Sinh viên thực hiện |
| Mã giảm giá (Coupon) | US-15 | 0.5 ngày | Sinh viên thực hiện |
| Nâng cấp tồn kho theo nguyên liệu (Ingredient, ProductIngredient, InventoryLog) | US-27 | 1 ngày | Sinh viên thực hiện |
| Cập nhật trạng thái đơn hàng thời gian thực (SignalR) | US-13 | 1 ngày | Sinh viên thực hiện |
| Thông báo Email (Mailtrap) + SMS mô phỏng | US-17 | 0.5 ngày | Sinh viên thực hiện |
| Trang Lịch sử đơn hàng cho Staff/Shipper | US-23 | 0.5 ngày | Sinh viên thực hiện |
| Quản lý danh mục (CRUD) | US-24 | 0.5 ngày | Sinh viên thực hiện |
| Quản lý sản phẩm đầy đủ (CRUD + upload ảnh + xóa mềm) | US-25 | 1 ngày | Sinh viên thực hiện |
| Quản lý người dùng (đổi vai trò, khóa/mở tài khoản) | US-26 | 0.5 ngày | Sinh viên thực hiện |
| Thống kê báo cáo (bảng + Chart.js) | US-28 | 1 ngày | Sinh viên thực hiện |
| Thiết kế giao diện thương hiệu riêng cho khách hàng (theme.css) | US-32 | 1 ngày | Sinh viên thực hiện |
| API xác thực JWT cho ứng dụng di động | US-29 | 1 ngày | Sinh viên thực hiện |
| Unit Test cho CouponService và OrderStatusMachine | US-30 | 0.5 ngày | Sinh viên thực hiện |
| Đa ngôn ngữ Việt/Anh | US-31 | 0.5 ngày | Sinh viên thực hiện |
| Viết báo cáo tổng kết đồ án | — | 1 ngày | Sinh viên thực hiện |

**Tổng ước lượng:** ~13 ngày công việc — nhiều hơn Sprint 1, chấp nhận được vì đã quen kiến trúc hệ thống nên tốc độ triển khai nhanh hơn.

## Định nghĩa hoàn thành (Definition of Done)

- Giữ nguyên tiêu chí như Sprint 1 (chạy được thật, không lỗi biên dịch, đã test tay đường vui + đường lỗi).
- Bổ sung tiêu chí mới: các tính năng tích hợp dịch vụ bên ngoài (VNPay, SMTP) phải được kiểm thử với dữ liệu/thẻ test thật của dịch vụ Sandbox tương ứng, không chỉ kiểm thử bằng cách đọc code.

## Rủi ro đã xác định trước Sprint

- Tích hợp VNPay có phụ thuộc bên ngoài (thời gian phản hồi email cấp thông tin kết nối từ VNPay có thể mất vài giờ đến vài ngày) — đã chủ động đăng ký sớm ngay đầu Sprint để không bị chặn tiến độ.
- Khối lượng công việc Sprint 2 lớn hơn Sprint 1 — cần ưu tiên rõ các task P0 (thanh toán, quản trị, thống kê) trước, các task P2 (JWT, Unit Test, đa ngôn ngữ) làm sau cùng và có thể cắt giảm nếu thiếu thời gian.
