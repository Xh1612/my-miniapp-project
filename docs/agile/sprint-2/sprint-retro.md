# Sprint Retrospective — Sprint 2

**Ngày:** 11/07/2026

## 😀 Điều đã làm tốt (What went well)

- Chủ động đăng ký tài khoản Sandbox VNPay ngay từ ngày đầu Sprint (biết trước đây là phụ thuộc bên ngoài có độ trễ phản hồi khó kiểm soát) giúp không bị chặn tiến độ ở giữa Sprint.
- Cách tiếp cận "thêm JWT như một lựa chọn xác thực song song, không thay thế cơ chế cookie mặc định" giúp tích hợp tính năng mới mà zero rủi ro phá vỡ toàn bộ hệ thống đã hoạt động ổn định từ Sprint 1 — đây là một quyết định kỹ thuật quan trọng, thể hiện tư duy "mở rộng an toàn" thay vì "sửa đổi rủi ro".
- Việc tách các nghiệp vụ phức tạp thành Service riêng (CouponService, VnPayService, NotificationService) từ Sprint 1 giúp Sprint 2 bổ sung tính năng mới rất nhanh, ít đụng chạm code cũ.

## 😕 Điều chưa tốt (What didn't go well)

- Xảy ra 2 lần lỗi liên quan đến việc "quên đồng bộ code khi làm theo nhiều bước hướng dẫn liên tiếp" (thiếu Service khiến build lỗi; dán trùng code thông báo 2 lần) — cho thấy cần chậm lại và đọc kỹ toàn bộ đoạn code hiện có trước khi chỉnh sửa, thay vì chỉ dán thêm theo quán tính.
- Khối lượng công việc Sprint 2 ước lượng hơi thấp so với thực tế — nhiều task như tích hợp VNPay và thông báo Email/SMS phát sinh thời gian debug nhiều hơn dự kiến ban đầu.
- Phần Unit Test chỉ kịp viết cho 2 Service quan trọng nhất (CouponService, OrderStatusMachine), chưa bao phủ được các nghiệp vụ khác — nếu có Sprint 3, đây nên là ưu tiên đầu danh sách.

## 🎯 Bài học tổng kết toàn dự án (rút ra sau 2 Sprint)

1. Đầu tư đúng vào kiến trúc nền tảng ở Sprint đầu (Area, Service Layer, transaction) mang lại lợi ích rõ rệt về tốc độ phát triển ở Sprint sau — đúng theo tinh thần Agile là ưu tiên giá trị lâu dài hơn tốc độ ngắn hạn.
2. Phần lớn lỗi phát sinh trong dự án không phải do sai logic phức tạp, mà do **sai sót đồng bộ** giữa các file liên quan khi thay đổi cấu hình hoặc dán code — kỷ luật rà soát lại toàn bộ thay đổi trước khi chuyển sang việc tiếp theo quan trọng không kém việc viết đúng logic.
3. Ghi nhật ký standup hằng ngày, kể cả khi làm việc một mình, thực sự hữu ích để nhìn lại được bức tranh tổng thể tiến độ và các blocker đã gặp — dữ liệu này sau đó trở thành nguồn tư liệu quý cho phần báo cáo tổng kết đồ án.
