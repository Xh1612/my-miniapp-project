# Hương Quê Việt — my-miniapp-project

Website thương mại điện tử đặt món ăn Việt Nam trực tuyến, xây dựng bằng **ASP.NET Core MVC (.NET 8)**, phát triển theo mô hình **Scrum** qua 2 Sprint.

## Giới thiệu nhanh

Hệ thống cho phép khách hàng xem thực đơn, đặt món, thanh toán (COD/VNPay) và theo dõi đơn hàng theo thời gian thực; đồng thời cung cấp phân hệ vận hành nội bộ cho Nhân viên bếp, Shipper, và phân hệ quản trị toàn diện cho Admin (danh mục, sản phẩm, người dùng, nguyên liệu, thống kê). Chi tiết đầy đủ về nghiệp vụ và kiến trúc xem tại [`docs/architecture/architecture-overview.md`](docs/architecture/architecture-overview.md).

## Công nghệ sử dụng

ASP.NET Core MVC (.NET 8) · Entity Framework Core (Code First) · SQL Server · ASP.NET Core Identity + JWT · SignalR · VNPay Sandbox · Chart.js · xUnit

## Cách cài đặt và chạy

1. Yêu cầu: .NET 8 SDK, SQL Server (LocalDB đủ dùng), Visual Studio 2022 (khuyến nghị) hoặc `dotnet` CLI.

2. Mở thư mục `src/` bằng Visual Studio, hoặc từ dòng lệnh:

   ```bash
   cd src
   dotnet restore
Cập nhật src/appsettings.json: điền RestaurantLocation, và nếu muốn test đầy đủ tính năng thanh toán/thông báo, điền thêm Vnpay (đăng ký Sandbox tại VNPay) và Smtp (đăng ký free tại Mailtrap.io). Không điền cũng chạy được các chức năng còn lại bình thường.

Tạo database:

dotnet ef database update

(nếu chưa có dotnet-ef, cài qua dotnet tool install --global dotnet-ef)

Chạy ứng dụng:

dotnet run

hoặc nhấn F5 trong Visual Studio.

Sau khi đăng ký tài khoản đầu tiên, tiến hành gán quyền Admin thủ công thông qua câu lệnh SQL bên dưới (tính năng khởi tạo tài khoản quản trị viên đầu tiên được ẩn để đảm bảo an toàn hệ thống, vì phân hệ quản lý người dùng yêu cầu quyền Admin):

INSERT INTO AspNetUserRoles (UserId, RoleId)
SELECT u.Id, r.Id FROM AspNetUsers u, AspNetRoles r
WHERE u.Email = '<email của bạn>' AND r.Name = 'Admin';
Chạy Unit Test
cd tests
dotnet test

Thư mục tests/ được đặt ngang hàng với src/ (không lồng bên trong) theo đúng quy ước chuẩn của giải pháp .NET (solution có nhiều project: 1 project chạy được + 1 project test riêng) — đây là điểm điều chỉnh nhỏ so với cây thư mục mẫu ban đầu (vốn thiết kế chung cho các framework JavaScript không có khái niệm project/solution tách biệt).

Cấu trúc thư mục
my-miniapp-project/
├── .github/                 → Template cho Issue (User Story, Bug) và Pull Request
├── docs/
│   ├── agile/               → Toàn bộ tài liệu Scrum: Product Backlog, 2 Sprint
│   └── architecture/       → Kiến trúc hệ thống, thiết kế cơ sở dữ liệu
├── src/                     → Mã nguồn chính (ASP.NET Core MVC)
│   ├── Areas/Admin/         → Phân hệ quản trị (Controller + View riêng)
│   ├── Controllers/         → Controller cho khách hàng
│   ├── Models/              → Entity + ViewModel
│   ├── Data/                → DbContext
│   ├── Services/            → Nghiệp vụ tách riêng (Coupon, VNPay, Notification)
│   ├── Helpers/             → Haversine, State Machine, thư viện chữ ký VNPay
│   ├── Hubs/                → SignalR
│   ├── ViewComponents/      → Giỏ hàng mini trên Navbar
│   ├── Views/               → Giao diện Razor
│   └── wwwroot/             → CSS, ảnh upload
├── tests/                   → Unit Test (xUnit)
└── README.md
Quy trình phát triển (Agile/Scrum)

Dự án được thực hiện qua 2 Sprint, theo đúng các sự kiện Scrum chuẩn:

Product Backlog — toàn bộ User Story, ưu tiên theo P0/P1/P2
Sprint 1 — Nền tảng hệ thống + luồng mua hàng cơ bản
Sprint 2 — Thanh toán trực tuyến, phân hệ quản trị, tính năng mở rộng

Mỗi Sprint có đủ 4 tài liệu:

sprint-planning.md
daily-standups.md
sprint-review.md
sprint-retro.md
Ghi chú về hình thức thực hiện

Đồ án được thực hiện bởi nhóm 6 thành viên, tuân thủ mô hình Scrum qua 2 Sprint. Các thành viên phối hợp thực hiện các User Story được phân công trong từng Sprint và tham gia đầy đủ các sự kiện Scrum gồm Sprint Planning, Daily Standup, Sprint Review và Sprint Retrospective.

Mô hình này giúp nhóm duy trì quy trình phát triển có tổ chức, theo dõi tiến độ công việc, phối hợp giữa các thành viên và cải thiện cách làm việc qua từng Sprint theo tinh thần Agile/Scrum.

Giới hạn hiện tại
Hỗ trợ một cửa hàng duy nhất, chưa có mô hình đa chi nhánh.
Gửi SMS ở dạng mô phỏng (ghi log), chưa tích hợp nhà mạng thật.
Ảnh sản phẩm lưu trực tiếp trên máy chủ ứng dụng (wwwroot/uploads), chưa dùng dịch vụ lưu trữ đám mây.
