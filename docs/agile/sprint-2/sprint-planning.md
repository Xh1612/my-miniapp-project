# Sprint 2 Planning

**Thời gian:** 31/07/2026 – 19/08/2026

**Team:** 6 thành viên

## Thành viên và vai trò

| Thành viên         | Vai trò chính trong Sprint 2                    |
| ------------------ | ----------------------------------------------- |
| Huỳnh Đăng Khoa    | UI/UX, Front-end, Theme, Dashboard              |
| Nguyễn Phi Hùng    | Authentication, VNPay, SignalR, JWT, phân quyền |
| Nguyễn Trọng Nghĩa | Database, nghiệp vụ, thống kê, dữ liệu          |
| Ngô Nhựt Nam       | Backend Service, Inventory, Admin, Integration  |
| Nguyễn Chí Hoàng   | Testing, Product/Admin integration, Unit Test   |
| Phạm Thị Hồng Gấm  | UI/UX, Notification UI, Auth UI, responsive     |

---

## Sprint Goal

> **Mở rộng và hoàn thiện hệ thống trên nền tảng đã xây dựng ở Sprint 1**, tập trung tích hợp thanh toán VNPay, mã giảm giá, tồn kho theo nguyên liệu, cập nhật trạng thái đơn hàng thời gian thực và hệ thống thông báo; đồng thời hoàn thiện các chức năng quản trị, thống kê, giao diện thương hiệu, JWT API, Unit Test và đa ngôn ngữ để đưa sản phẩm đến trạng thái sẵn sàng cho kiểm thử và báo cáo cuối kỳ.

> **Phạm vi Sprint 2 không xây dựng lại các chức năng nền tảng của Sprint 1** như Cart, Checkout cơ bản, Order Status Machine, Admin Area hay Identity. Các task Sprint 2 sử dụng và mở rộng những nền tảng đã hoàn thành ở Sprint 1.

---

## Task được kéo từ Product Backlog vào Sprint này

| #  | Task                                                                                       | User Story   | Ước lượng | Người phụ trách                                     |
| -- | ------------------------------------------------------------------------------------------ | ------------ | --------: | --------------------------------------------------- |
| 1  | Mở rộng đăng ký với họ tên + SĐT và thiết kế lại giao diện Login/Register theo thương hiệu | US-18, US-19 |    1 ngày | Huỳnh Đăng Khoa + Phạm Thị Hồng Gấm                 |
| 2  | Tích hợp VNPay Sandbox vào luồng thanh toán hiện có                                        | US-16        |  1.5 ngày | Nguyễn Phi Hùng                                     |
| 3  | Xây dựng và tích hợp mã giảm giá Coupon vào luồng đặt hàng                                 | US-15        |  0.5 ngày | Nguyễn Chí Hoàng + Nguyễn Phi Hùng                  |
| 4  | Nâng cấp tồn kho từ mức cơ bản sang quản lý theo nguyên liệu                               | US-27        |    1 ngày | Nguyễn Trọng Nghĩa + Ngô Nhựt Nam                   |
| 5  | Tích hợp SignalR để cập nhật trạng thái đơn hàng thời gian thực                            | US-13        |    1 ngày | Nguyễn Phi Hùng + Ngô Nhựt Nam                      |
| 6  | Bổ sung Email qua Mailtrap và SMS mô phỏng dựa trên trạng thái đơn                         | US-17        |  0.5 ngày | Ngô Nhựt Nam + Phạm Thị Hồng Gấm                    |
| 7  | Bổ sung trang lịch sử đơn hàng cho Staff/Shipper                                           | US-23        |  0.5 ngày | Nguyễn Chí Hoàng + Phạm Thị Hồng Gấm                |
| 8  | Hoàn thiện CRUD quản lý danh mục trong Admin                                               | US-24        |  0.5 ngày | Nguyễn Phi Hùng + Nguyễn Trọng Nghĩa                |
| 9  | Hoàn thiện CRUD sản phẩm, upload ảnh và xóa mềm                                            | US-25        |    1 ngày | Ngô Nhựt Nam + Nguyễn Chí Hoàng                     |
| 10 | Bổ sung quản lý người dùng: đổi vai trò, khóa/mở tài khoản                                 | US-26        |  0.5 ngày | Ngô Nhựt Nam + Nguyễn Phi Hùng                      |
| 11 | Xây dựng Dashboard thống kê bằng bảng và Chart.js                                          | US-28        |    1 ngày | Nguyễn Trọng Nghĩa + Ngô Nhựt Nam + Huỳnh Đăng Khoa |
| 12 | Hoàn thiện giao diện thương hiệu khách hàng bằng `theme.css`                               | US-32        |    1 ngày | Huỳnh Đăng Khoa + Phạm Thị Hồng Gấm                 |
| 13 | Xây dựng API xác thực JWT dành cho ứng dụng mobile                                         | US-29        |    1 ngày | Nguyễn Phi Hùng                                     |
| 14 | Viết Unit Test cho `CouponService` và `OrderStatusMachine`                                 | US-30        |  0.5 ngày | Nguyễn Chí Hoàng                                    |
| 15 | Bổ sung hỗ trợ đa ngôn ngữ Việt/Anh                                                        | US-31        |  0.5 ngày | Phạm Thị Hồng Gấm + Huỳnh Đăng Khoa                 |
| 16 | Hoàn thiện tài liệu và báo cáo tổng kết đồ án                                              | —            |    1 ngày | Cả nhóm                                             |

**Tổng ước lượng:** khoảng **13 ngày công việc**.

> Các ước lượng được phân bổ theo khối lượng tính năng. Một số task có nhiều thành viên phối hợp nên có thể thực hiện song song.

---

## Phân biệt phạm vi với Sprint 1

Để tránh trùng lặp giữa hai Sprint, các task Sprint 2 được xác định là **mở rộng hoặc hoàn thiện** những nền tảng đã có.

| Sprint 1 đã hoàn thành                  | Sprint 2 tiếp tục mở rộng                    |
| --------------------------------------- | -------------------------------------------- |
| Identity / Login / Register cơ bản      | Bổ sung SĐT + thiết kế Auth theo thương hiệu |
| Checkout cơ bản                         | Tích hợp VNPay Sandbox                       |
| Order Status Machine                    | Cập nhật trạng thái realtime bằng SignalR    |
| Tồn kho cơ bản trong quá trình đặt hàng | Quản lý tồn kho theo Ingredient              |
| Admin Area                              | Hoàn thiện các module CRUD bên trong Admin   |
| Product/Category Model                  | CRUD Category/Product + upload ảnh + xóa mềm |
| Luồng đặt hàng                          | Coupon và thanh toán trực tuyến              |
| Xử lý đơn Staff/Shipper                 | Lịch sử đơn hàng + notification              |
| Giao diện cơ bản                        | Theme thương hiệu + responsive hoàn thiện    |
| Chưa có API mobile                      | JWT API                                      |
| Kiểm thử thủ công                       | Unit Test                                    |
| Chưa có đa ngôn ngữ                     | Việt/Anh                                     |

### Nguyên tắc

**Sprint 1: Xây dựng nền tảng và nghiệp vụ cốt lõi.**

**Sprint 2: Tích hợp, nâng cấp và hoàn thiện trên nền tảng Sprint 1.**

Do đó, những task có liên quan đến Sprint 1 không được xem là làm lại mà là **phần mở rộng của chức năng đã có**.

---

# Definition of Done

Một task Sprint 2 được xem là hoàn thành khi:

* Code đã được tích hợp vào project chính.
* Project build thành công, không còn lỗi biên dịch.
* Chức năng chạy được trên môi trường phát triển.
* Đã kiểm thử đường đi chính (happy path).
* Đã kiểm thử các trường hợp lỗi quan trọng.
* Không làm hỏng các chức năng đã hoàn thành ở Sprint 1.
* Code được kiểm tra và tích hợp vào nhánh chính của nhóm.

### Tiêu chí bổ sung cho Sprint 2

**VNPay:**

* Tạo được URL thanh toán hợp lệ.
* Callback được xử lý.
* Kiểm tra được trạng thái giao dịch.
* Kiểm thử bằng môi trường Sandbox.

**Email/SMS:**

* Email được gửi qua Mailtrap.
* SMS được mô phỏng thành công.
* Lỗi gửi notification không làm crash luồng xử lý đơn hàng.

**SignalR:**

* Client nhận được cập nhật khi trạng thái đơn thay đổi.
* Không làm ảnh hưởng đến cơ chế cập nhật trạng thái hiện có.

**JWT:**

* API tạo được token hợp lệ.
* Token được xác thực đúng.
* Token không hợp lệ hoặc hết hạn bị từ chối.
* JWT không làm ảnh hưởng đến Cookie Authentication của website.

**Unit Test:**

* `CouponService` có test cho các trường hợp hợp lệ và không hợp lệ.
* `OrderStatusMachine` có test cho các chuyển trạng thái hợp lệ và không hợp lệ.

---

# Rủi ro đã xác định trước Sprint

### 1. Phụ thuộc VNPay Sandbox

VNPay là dịch vụ bên ngoài nên việc cấp thông tin kết nối và quá trình kiểm thử có thể ảnh hưởng tiến độ.

**Biện pháp:**

* Chuẩn bị tích hợp VNPay ngay đầu Sprint.
* Phát triển Service và xử lý callback song song trong thời gian chờ thông tin Sandbox.
* Sử dụng dữ liệu cấu hình riêng cho môi trường Sandbox.

### 2. SignalR ảnh hưởng đến luồng trạng thái hiện có

Sprint 1 đã có cơ chế xử lý trạng thái đơn hàng. Việc bổ sung SignalR có thể gây lỗi nếu thay đổi trực tiếp nghiệp vụ cũ.

**Biện pháp:**

* Giữ nguyên `OrderStatusMachine`.
* SignalR chỉ đảm nhiệm việc **broadcast sự thay đổi trạng thái**.
* Kiểm thử lại các trạng thái trước khi tích hợp.

### 3. Nâng cấp tồn kho

Việc chuyển từ tồn kho cơ bản sang tồn kho theo nguyên liệu có thể ảnh hưởng đến luồng đặt hàng.

**Biện pháp:**

* Xây dựng `Ingredient`, `ProductIngredient`, `InventoryLog` riêng.
* Kiểm thử trường hợp đủ và thiếu nguyên liệu.
* Đảm bảo transaction hiện có vẫn hoạt động.

### 4. Khối lượng Sprint lớn

Sprint 2 có nhiều tính năng mở rộng và tích hợp.

**Biện pháp ưu tiên:**

**P0 — bắt buộc:**

* VNPay
* Coupon
* Inventory
* SignalR
* Notification
* Admin CRUD
* Dashboard

**P1 — quan trọng:**

* Auth UI
* Theme
* Order History

**P2 — hoàn thiện kỹ thuật:**

* JWT
* Unit Test
* Đa ngôn ngữ
* Báo cáo

---

# Kế hoạch kiểm thử

| Nhóm chức năng | Nội dung kiểm thử                                      |
| -------------- | ------------------------------------------------------ |
| VNPay          | Thanh toán thành công, thất bại, callback              |
| Coupon         | Mã hợp lệ, hết hạn, không tồn tại, điều kiện không đạt |
| Inventory      | Đủ nguyên liệu, thiếu nguyên liệu, ghi InventoryLog    |
| SignalR        | Nhận trạng thái realtime, nhiều client                 |
| Email/SMS      | Gửi thành công, lỗi dịch vụ                            |
| Order History  | Đúng dữ liệu theo Staff/Shipper                        |
| Category       | Thêm, sửa, xóa và validation                           |
| Product        | CRUD, upload ảnh, xóa mềm                              |
| User           | Đổi role, khóa/mở tài khoản                            |
| Dashboard      | Đối chiếu số liệu với Database                         |
| JWT            | Token hợp lệ, hết hạn, không hợp lệ                    |
| Unit Test      | CouponService, OrderStatusMachine                      |
| UI             | Responsive, theme, Việt/Anh                            |

---

# Kết quả mong đợi của Sprint

Sau Sprint 2, hệ thống đạt được:

1. Thanh toán online qua VNPay Sandbox.
2. Coupon được tích hợp vào luồng đặt hàng.
3. Tồn kho được quản lý theo nguyên liệu.
4. Trạng thái đơn hàng được cập nhật realtime.
5. Có Email và SMS mô phỏng.
6. Staff/Shipper có lịch sử đơn hàng.
7. Admin có đầy đủ các chức năng quản lý Category, Product và User.
8. Có Dashboard và biểu đồ thống kê.
9. Giao diện khách hàng có nhận diện thương hiệu thống nhất.
10. Có JWT API cho ứng dụng mobile.
11. Có Unit Test cho các nghiệp vụ quan trọng.
12. Hỗ trợ tiếng Việt và tiếng Anh.
13. Hoàn thiện tài liệu và chuẩn bị cho Sprint Review.

---


