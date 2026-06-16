# Sprint 1 Planning

**Thời gian:** 16/06/2026 – 27/06/2026 (2 tuần)
**Team:** 1 thành viên (Product Owner kiêm Scrum Master kiêm Developer)

## Sprint Goal

> Dựng xong nền tảng kỹ thuật của hệ thống (kiến trúc project, xác thực, cơ sở dữ liệu cốt lõi) và hoàn thiện được **một luồng mua hàng end-to-end** — từ lúc khách xem thực đơn đến lúc đặt hàng thành công và nhân viên bếp/shipper xử lý được đơn — để có một bản demo chạy được thật ngay cuối Sprint 1, thay vì chỉ có các phần rời rạc.

## Task được kéo từ Product Backlog vào Sprint này

| Task | User Story liên quan | Ước lượng | Người phụ trách |
|---|---|---|---|
| Khởi tạo project ASP.NET Core MVC (.NET 8), cấu hình Identity | US-01 | 0.5 ngày | Sinh viên thực hiện |
| Tạo Area "Admin" + layout quản trị riêng | US-02 | 0.5 ngày | Sinh viên thực hiện |
| Thiết kế Model + DbContext cho Category/Product/Order/OrderItem, seed dữ liệu mẫu | US-03 | 1 ngày | Sinh viên thực hiện |
| Trang chủ (món nổi bật/mới nhất) | US-04 | 0.5 ngày | Sinh viên thực hiện |
| Trang thực đơn + lọc danh mục + tìm kiếm đơn giản | US-05, US-06 | 1 ngày | Sinh viên thực hiện |
| Tìm kiếm nâng cao | US-07 | 0.5 ngày | Sinh viên thực hiện |
| Trang chi tiết sản phẩm + đánh giá | US-08 | 1 ngày | Sinh viên thực hiện |
| Giỏ hàng (Session) + View Component hiển thị số lượng | US-09 | 1 ngày | Sinh viên thực hiện |
| Quản lý địa chỉ giao hàng + công thức tính khoảng cách | US-10, US-11 | 1 ngày | Sinh viên thực hiện |
| Đặt hàng có transaction (kiểm tra & trừ tồn kho an toàn) | US-12 | 1.5 ngày | Sinh viên thực hiện |
| Trang xử lý đơn cho Nhân viên bếp + Shipper, có kiểm soát chuyển trạng thái | US-20, US-21, US-22 | 1.5 ngày | Sinh viên thực hiện |
| Hủy đơn khi còn ở trạng thái cho phép | US-14 | 0.5 ngày | Sinh viên thực hiện |

**Tổng ước lượng:** ~11 ngày làm việc trong 2 tuần Sprint (có buffer cho việc debug phát sinh).

## Định nghĩa hoàn thành (Definition of Done)

- Chức năng chạy được thật qua thao tác F5, không chỉ code chưa test.
- Không còn lỗi biên dịch, không còn ngoại lệ chưa xử lý khi thao tác đúng luồng dự kiến.
- Đã kiểm thử tay ít nhất một kịch bản "đường vui" (happy path) và một kịch bản lỗi dự kiến (VD: đặt hàng vượt tồn kho).

## Rủi ro đã xác định trước Sprint

- Đây là lần đầu áp dụng đồng thời nhiều kỹ thuật mới (Area, transaction, View Component) — có thể phát sinh thời gian tìm hiểu ngoài dự kiến.
- Việc thiết kế đúng cấu trúc Model ngay từ đầu quan trọng vì các Sprint sau sẽ mở rộng thêm bảng liên quan (Coupon, Ingredient...) — nếu thiết kế sai sẽ phải refactor tốn thời gian.
