# Sprint Review — Sprint 1

**Ngày:** 27/06/2026
**Người tham dự:** Sinh viên thực hiện (Product Owner/Developer), Giảng viên hướng dẫn (đóng vai trò khách hàng góp ý)

## Sprint Goal đã đạt được?

✅ **Đạt.** Luồng mua hàng end-to-end đã chạy được thật: khách vãng lai xem thực đơn → đăng ký/đăng nhập → thêm giỏ hàng → thêm địa chỉ → đặt hàng (có transaction an toàn) → Nhân viên bếp xác nhận → Shipper nhận và giao. Toàn bộ luồng được demo trực tiếp trong buổi Review.

## Các tính năng đã hoàn thành (Done)

- Nền tảng project: ASP.NET Core MVC + Identity + Area Admin (US-01, US-02, US-03)
- Trang chủ, thực đơn, tìm kiếm đơn giản & nâng cao (US-04 → US-07)
- Chi tiết sản phẩm + đánh giá (US-08)
- Giỏ hàng + View Component (US-09)
- Quản lý địa chỉ + tính phí ship tự động (US-10, US-11)
- Đặt hàng với transaction đảm bảo an toàn tồn kho (US-12)
- Hủy đơn (US-14)
- Xử lý đơn cho Nhân viên bếp/Shipper có kiểm soát trạng thái (US-20, US-21, US-22)

## Demo trực tiếp

Đã demo trực tiếp trên máy: tạo đơn hàng thành công, thử đặt vượt tồn kho để chứng minh rollback hoạt động đúng, đăng nhập lần lượt 3 vai trò (Customer, Staff, Shipper) để chứng minh mỗi vai trò thấy đúng phần việc của mình.

## Phản hồi từ giảng viên/khách hàng

- Đánh giá cao việc đã có bản chạy được thật ngay từ Sprint đầu tiên thay vì chỉ có tài liệu thiết kế.
- Góp ý: nên bổ sung xác nhận qua email/SMS để khách yên tâm hơn sau khi đặt hàng — đã ghi nhận vào Backlog cho Sprint 2 (US-17).
- Góp ý: cân nhắc thêm phương thức thanh toán trực tuyến thay vì chỉ COD — đã có sẵn trong Backlog, ưu tiên cho Sprint 2 (US-16).

## Chưa làm được / Đẩy sang Sprint 2

- Thanh toán trực tuyến (VNPay)
- Mã giảm giá
- Toàn bộ phân hệ quản trị (danh mục, sản phẩm, người dùng, nguyên liệu, thống kê)
- Cập nhật trạng thái theo thời gian thực (hiện tại khách phải tự tải lại trang để thấy trạng thái mới)
- Giao diện khách hàng vẫn đang dùng Bootstrap mặc định, chưa có bản sắc thương hiệu riêng
