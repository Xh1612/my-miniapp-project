# Sprint Retrospective — Sprint 1

**Ngày:** 27/06/2026
**Định dạng:** What went well / What didn't go well / Action items cho Sprint 2

## 😀 Điều đã làm tốt (What went well)

- Quyết định tạo Area "Admin" **ngay từ Sprint 1, trước khi viết bất kỳ Controller quản trị nào** là quyết định đúng đắn nhất của Sprint này — tránh được hoàn toàn công sức "dọn dẹp lại cấu trúc" (di chuyển Controller/View vào Area) mà lẽ ra sẽ phải làm nếu để đến Sprint sau mới nghĩ tới việc phân tách.
- Việc seed sẵn dữ liệu mẫu (Category, Product) ngay trong Migration giúp có dữ liệu test ngay từ ngày đầu, không mất thời gian gõ tay SQL lặp lại mỗi khi cần reset database.
- Quyết định bọc toàn bộ logic đặt hàng trong một transaction duy nhất ngay từ đầu (thay vì làm phần cơ bản trước rồi "thêm transaction sau") giúp tránh được việc phải refactor lại luồng nghiệp vụ phức tạp này ở Sprint sau.

## 😕 Điều chưa tốt (What didn't go well)

- Tốn khá nhiều thời gian debug lỗi `SqlTransaction has completed` vì ban đầu đọc nhầm đây là lỗi gốc thay vì lỗi thứ cấp che lỗi thật — nếu ngay từ đầu bọc `RollbackAsync()` trong try/catch riêng (như cách làm cuối cùng) thì đã tiết kiệm được thời gian debug.
- Nhiều lỗi phát sinh (UserManager sai kiểu, thiếu `_ViewImports.cshtml` trong Area, thiếu View cho action đã viết) đều thuộc dạng "quên rà lại file liên quan sau khi đổi cấu hình lớn" — cho thấy cần một checklist kiểm tra nhanh sau mỗi thay đổi kiến trúc.
- Chưa viết được bất kỳ dòng test tự động nào trong Sprint này — hoàn toàn dựa vào kiểm thử tay, rủi ro bỏ sót khi hệ thống phức tạp dần lên ở Sprint 2.

## 🎯 Action Items cho Sprint 2

1. Khi thêm một Area hoặc thư mục cấu hình mới, chủ động kiểm tra ngay các file `_ViewStart`/`_ViewImports` cần thiết thay vì đợi gặp lỗi mới nhớ ra.
2. Khi gặp exception, luôn đọc kỹ `InnerException`/stack trace đầy đủ trước khi kết luận nguyên nhân, tránh sửa nhầm chỗ.
3. Cân nhắc dành một phần nhỏ thời gian Sprint 2 để viết Unit Test cho ít nhất các nghiệp vụ có nhiều nhánh điều kiện dễ sai sót (ví dụ: tính mã giảm giá, chuyển trạng thái đơn hàng).
