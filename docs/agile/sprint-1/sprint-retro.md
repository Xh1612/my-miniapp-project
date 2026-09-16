# Sprint Retrospective — Sprint 1

**Ngày:** 27/06/2026

**Sprint:** Sprint 1

**Thời gian Sprint:** 16/06/2026 – 27/06/2026

**Team:** 6 thành viên

**Định dạng:** What went well / What didn't go well / Action Items

---

## 😀 Điều đã làm tốt (What went well)

### 1. Thống nhất cấu trúc project ngay từ đầu

Team đã thống nhất sử dụng ASP.NET Core MVC (.NET 8), EF Core và tổ chức project theo các module rõ ràng như `Controllers`, `Models`, `Data`, `Services`, `Areas/Admin`, `Views` và `wwwroot`.

Việc thống nhất cấu trúc từ đầu giúp các thành viên dễ dàng làm việc trên các phần khác nhau của hệ thống và hạn chế việc phải thay đổi cấu trúc project quá nhiều về sau.

### 2. Phân chia công việc theo chức năng

Các thành viên được phân chia theo những nhóm chức năng khác nhau như:

- UI/UX và giao diện.
- Authentication và Authorization.
- Database và Model.
- EF Core và Backend.
- Product, Menu và Cart.
- Checkout, Staff và Shipper.

Việc phân chia này giúp các thành viên có thể làm việc song song thay vì phải chờ một người hoàn thành toàn bộ hệ thống.

### 3. Hoàn thiện được luồng mua hàng chính

Team đã tập trung xây dựng luồng chính của hệ thống:

```text
Xem thực đơn
    ↓
Tìm kiếm / Lọc món
    ↓
Xem chi tiết món
    ↓
Thêm vào giỏ hàng
    ↓
Chọn địa chỉ giao hàng
    ↓
Checkout
    ↓
Đặt hàng
    ↓
Nhân viên bếp xử lý
    ↓
Shipper xử lý đơn
