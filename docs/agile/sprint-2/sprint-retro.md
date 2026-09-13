# Sprint Retrospective — Sprint 2

**Ngày:** 19/08/2026  
**Sprint:** Sprint 2  
**Thành viên:** Huỳnh Đăng Khoa, Nguyễn Phi Hùng, Nguyễn Trọng Nghĩa, Ngô Nhựt Nam, Nguyễn Chí Hoàng, Phạm Thị Hồng Gấm

---

## 😀 Điều đã làm tốt (What went well)

- Hoàn thiện và mở rộng các chức năng trên nền tảng đã xây dựng từ Sprint 1 thay vì phải xây dựng lại các module cốt lõi.
- Việc tách các nghiệp vụ phức tạp thành các Service riêng như `CouponService`, `VnPayService` và `NotificationService` giúp việc tích hợp các tính năng mới dễ quản lý và hạn chế ảnh hưởng đến các chức năng cũ.
- Tích hợp VNPay Sandbox vào luồng thanh toán hiện có, giúp hệ thống hỗ trợ thêm hình thức thanh toán trực tuyến bên cạnh COD.
- Bổ sung SignalR để cập nhật trạng thái đơn hàng theo thời gian thực, giúp luồng xử lý giữa Customer, Staff và Shipper rõ ràng hơn.
- Hoàn thiện các chức năng quản trị như Category CRUD, Product CRUD, User Management và Dashboard thống kê.
- Bổ sung quản lý nguyên liệu và tồn kho, giúp hệ thống phù hợp hơn với nghiệp vụ của website bán món ăn.
- Việc bổ sung Unit Test cho `CouponService` và `OrderStatusMachine` giúp kiểm tra lại các nghiệp vụ quan trọng và hạn chế lỗi khi thay đổi code.
- Nhóm đã chủ động kiểm tra và sửa các lỗi phát sinh trong quá trình tích hợp, đặc biệt là lỗi liên quan đến Service, Notification và xác thực JWT.
- Daily Standup được sử dụng để theo dõi tiến độ, xác định blocker và phân chia công việc cụ thể cho từng thành viên.

---

## 😕 Điều chưa tốt (What didn't go well)

- Một số task có nhiều thành phần phụ thuộc lẫn nhau nên việc triển khai đôi lúc bị chậm, đặc biệt với các chức năng liên quan đến VNPay, Notification và SignalR.
- Trong quá trình tích hợp Notification Service, xảy ra lỗi build do thiếu hoặc chưa đăng ký đầy đủ các Service cần thiết. Điều này cho thấy cần kiểm tra đồng bộ giữa Interface, Implementation và Dependency Injection.
- Có trường hợp code bị trùng hoặc đặt biến trong cùng scope gây lỗi compile. Nhóm cần kiểm tra lại toàn bộ đoạn code hiện có trước khi thêm các phần code mới.
- Khối lượng công việc của Sprint 2 khá lớn do vừa phát triển tính năng mới vừa phải tích hợp với các chức năng đã hoàn thành ở Sprint 1.
- Unit Test mới tập trung vào một số Service quan trọng như `CouponService` và `OrderStatusMachine`, chưa bao phủ toàn bộ nghiệp vụ của hệ thống.
- Việc kiểm tra giao diện trên nhiều màn hình và nhiều luồng sử dụng chưa được thực hiện đầy đủ ngay từ đầu.
- Một số task cần phối hợp giữa Backend, Database và UI nên đôi lúc việc bàn giao giữa các thành viên chưa thật sự đồng bộ.

---

## 🔧 Cần cải thiện (What can be improved)

### 1. Kiểm tra dependency trước khi code

Trước khi thêm một tính năng mới cần xác định rõ:

- Interface nào cần thêm?
- Service nào cần tạo?
- Service đã được đăng ký trong `Program.cs` chưa?
- Controller nào sử dụng Service?
- View hoặc JavaScript nào phụ thuộc vào chức năng đó?

Điều này giúp hạn chế lỗi build và lỗi runtime khi tích hợp.

### 2. Tăng cường Unit Test

Ở Sprint tiếp theo, nếu có thêm thời gian, nhóm nên mở rộng Unit Test cho:

- Coupon Service
- Order Service
- Payment Service
- Notification Service
- Order Status Machine
- Các nghiệp vụ liên quan đến tồn kho

### 3. Kiểm tra tích hợp thường xuyên

Không nên chờ đến cuối Sprint mới tích hợp các module.

Sau khi hoàn thành một chức năng nên kiểm tra ngay:

```text
Database
   ↓
Service
   ↓
Controller
   ↓
View / API
   ↓
User Flow
