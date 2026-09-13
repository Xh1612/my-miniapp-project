# Product Backlog — Hương Quê Việt

> Danh sách tổng hợp toàn bộ User Story của dự án, sắp xếp theo độ ưu tiên. Product Owner: nhóm sinh viên thực hiện đồ án. Backlog được refine trước mỗi Sprint Planning.

**Chú thích trạng thái:** ✅ Done · 🔄 In Progress · 📋 To Do

**Chú thích độ ưu tiên:** P0 = phải có (must-have) · P1 = nên có (should-have) · P2 = có thì tốt (nice-to-have)

## Epic 1 — Nền tảng hệ thống (Foundation)

| ID | User Story | Ưu tiên | Sprint | Trạng thái |
|---|---|---|---|---|
| US-01 | Là một **lập trình viên**, tôi muốn khởi tạo project ASP.NET Core MVC với Identity dựng sẵn, để có nền xác thực chuẩn thay vì tự viết từ đầu. | P0 | Sprint 1 | ✅ |
| US-02 | Là một **lập trình viên**, tôi muốn tách khu vực quản trị vào một Area riêng ngay từ đầu, để tránh phải tái cấu trúc project giữa chừng. | P0 | Sprint 1 | ✅ |
| US-03 | Là một **lập trình viên**, tôi muốn thiết kế đầy đủ các bảng dữ liệu cốt lõi (Category, Product, Order, OrderItem) và seed sẵn dữ liệu mẫu, để có dữ liệu test ngay từ Sprint đầu. | P0 | Sprint 1 | ✅ |

## Epic 2 — Trải nghiệm khách hàng (Customer Experience)

| ID | User Story | Ưu tiên | Sprint | Trạng thái |
|---|---|---|---|---|
| US-04 | Là một **khách vãng lai**, tôi muốn xem món ăn nổi bật và mới nhất ngay tại trang chủ, để nhanh chóng biết cửa hàng đang có gì ngon. | P0 | Sprint 1 | ✅ |
| US-05 | Là một **khách vãng lai**, tôi muốn xem toàn bộ thực đơn và lọc theo danh mục, để dễ dàng tìm món phù hợp khẩu vị. | P0 | Sprint 1 | ✅ |
| US-06 | Là một **khách vãng lai**, tôi muốn tìm kiếm món ăn theo tên, để tiết kiệm thời gian khi đã biết mình muốn ăn gì. | P0 | Sprint 1 | ✅ |
| US-07 | Là một **khách hàng**, tôi muốn tìm kiếm nâng cao theo nhiều tiêu chí (giá, danh mục, độ cay), để lọc chính xác hơn khi có yêu cầu cụ thể. | P1 | Sprint 1 | ✅ |
| US-08 | Là một **khách hàng**, tôi muốn xem đánh giá của người mua trước khi quyết định đặt món, để tin tưởng hơn vào chất lượng món ăn. | P1 | Sprint 1 | ✅ |
| US-09 | Là một **khách hàng**, tôi muốn thêm món vào giỏ hàng và xem lại trước khi đặt, để kiểm soát được số tiền phải trả. | P0 | Sprint 1 | ✅ |
| US-10 | Là một **khách hàng**, tôi muốn lưu nhiều địa chỉ giao hàng, để không phải nhập lại mỗi lần đặt món. | P0 | Sprint 1 | ✅ |
| US-11 | Là một **khách hàng**, tôi muốn hệ thống tự tính phí giao hàng theo khoảng cách, để biết chính xác tổng tiền trước khi xác nhận. | P0 | Sprint 1 | ✅ |
| US-12 | Là một **khách hàng**, tôi muốn đặt hàng mà không lo tồn kho bị trừ sai nếu có lỗi giữa chừng, để yên tâm về tính chính xác của đơn hàng. | P0 | Sprint 1 | ✅ |
| US-13 | Là một **khách hàng**, tôi muốn theo dõi trạng thái đơn hàng theo thời gian thực, để biết chính xác món ăn đang ở khâu nào. | P1 | Sprint 2 | ✅ |
| US-14 | Là một **khách hàng**, tôi muốn hủy đơn khi chưa được chuẩn bị, để linh hoạt thay đổi quyết định. | P1 | Sprint 1 | ✅ |
| US-15 | Là một **khách hàng**, tôi muốn nhập mã giảm giá khi thanh toán, để tiết kiệm chi phí. | P1 | Sprint 2 | ✅ |
| US-16 | Là một **khách hàng**, tôi muốn thanh toán trực tuyến qua VNPay thay vì chỉ tiền mặt, để thuận tiện hơn khi không có tiền mặt sẵn. | P1 | Sprint 2 | ✅ |
| US-17 | Là một **khách hàng**, tôi muốn nhận email/SMS xác nhận sau khi đặt hàng, để chắc chắn đơn đã được ghi nhận. | P2 | Sprint 2 | ✅ |
| US-18 | Là một **khách hàng mới**, tôi muốn đăng ký tài khoản kèm số điện thoại, để cửa hàng liên hệ được khi cần thiết cho việc giao hàng. | P0 | Sprint 2 | ✅ |
| US-19 | Là một **khách hàng**, tôi muốn trang đăng nhập/đăng ký mang đúng phong cách thương hiệu, để có trải nghiệm nhất quán và chuyên nghiệp. | P2 | Sprint 2 | ✅ |

## Epic 3 — Vận hành nội bộ (Kitchen & Delivery Operations)

| ID | User Story | Ưu tiên | Sprint | Trạng thái |
|---|---|---|---|---|
| US-20 | Là một **nhân viên bếp**, tôi muốn xem danh sách đơn hàng mới cần xác nhận, để bắt đầu chuẩn bị món kịp thời. | P0 | Sprint 1 | ✅ |
| US-21 | Là một **nhân viên bếp**, tôi muốn đơn hàng không thể nhảy trạng thái tùy tiện, để tránh sai sót quy trình bếp. | P0 | Sprint 1 | ✅ |
| US-22 | Là một **shipper**, tôi muốn xem đơn đã sẵn sàng để nhận giao, để chủ động sắp xếp lộ trình. | P0 | Sprint 1 | ✅ |
| US-23 | Là một **nhân viên bếp/shipper**, tôi muốn xem lại lịch sử đơn đã xử lý, để tra cứu khi cần đối chiếu. | P1 | Sprint 2 | ✅ |

## Epic 4 — Quản trị hệ thống (Admin)

| ID | User Story | Ưu tiên | Sprint | Trạng thái |
|---|---|---|---|---|
| US-24 | Là một **quản trị viên**, tôi muốn quản lý danh mục sản phẩm, để cơ cấu thực đơn linh hoạt theo nhu cầu kinh doanh. | P0 | Sprint 2 | ✅ |
| US-25 | Là một **quản trị viên**, tôi muốn thêm/sửa sản phẩm kèm tải ảnh trực tiếp, để thực đơn hiển thị hấp dẫn với hình ảnh thật. | P0 | Sprint 2 | ✅ |
| US-26 | Là một **quản trị viên**, tôi muốn quản lý vai trò và khóa/mở tài khoản người dùng, để kiểm soát quyền truy cập hệ thống. | P0 | Sprint 2 | ✅ |
| US-27 | Là một **quản trị viên**, tôi muốn theo dõi tồn kho nguyên liệu và nhận cảnh báo sắp hết, để chủ động nhập hàng kịp thời. | P1 | Sprint 2 | ✅ |
| US-28 | Là một **quản trị viên**, tôi muốn xem báo cáo doanh thu dạng bảng và biểu đồ, để nắm bắt tình hình kinh doanh trực quan. | P0 | Sprint 2 | ✅ |

## Epic 5 — Mở rộng & Chất lượng (Extended & Quality)

| ID | User Story | Ưu tiên | Sprint | Trạng thái |
|---|---|---|---|---|
| US-29 | Là một **lập trình viên**, tôi muốn cung cấp API có xác thực JWT, để làm nền tảng phát triển ứng dụng di động sau này. | P2 | Sprint 2 | ✅ |
| US-30 | Là một **lập trình viên**, tôi muốn viết Unit Test cho các nghiệp vụ quan trọng, để đảm bảo chất lượng khi chỉnh sửa code sau này. | P2 | Sprint 2 | ✅ |
| US-31 | Là một **khách hàng quốc tế**, tôi muốn xem giao diện bằng tiếng Anh, để sử dụng thuận tiện dù không rành tiếng Việt. | P2 | Sprint 2 | ✅ |
| US-32 | Là một **quản trị viên**, tôi muốn giao diện khách hàng có bản sắc riêng thay vì Bootstrap mặc định, để xây dựng hình ảnh thương hiệu. | P1 | Sprint 2 | ✅ |

---

*Backlog được duy trì xuyên suốt dự án; các mục ở Sprint 2 được ước lượng và cam kết tại buổi Sprint Planning của Sprint 2, sau khi đã hoàn thành refine dựa trên kết quả Sprint 1.*
