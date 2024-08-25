# Công Nghệ Shop - ASP.NET Core 8 MVC

## Giới thiệu

Dự án "Công Nghệ Shop" là một ứng dụng web bán đồ công nghệ được xây dựng bằng ASP.NET Core 8 và Entity Framework (EF). Ứng dụng sử dụng mô hình MVC (Model-View-Controller) để quản lý các sản phẩm công nghệ, giỏ hàng và đơn hàng của người dùng.

## Các tính năng

- **Quản lý sản phẩm**: Thêm, sửa, xóa sản phẩm.
- **Danh mục sản phẩm**: Hiển thị sản phẩm theo danh mục.
- **Giỏ hàng**: Thêm sản phẩm vào giỏ hàng và cập nhật số lượng.
- **Thanh toán**: Thực hiện thanh toán đơn hàng.
- **Đăng nhập/Đăng ký**: Quản lý người dùng và quyền truy cập.
- **Tìm kiếm**: Tìm kiếm sản phẩm theo tên hoặc danh mục.

## Cài đặt

### Yêu cầu

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (hoặc bất kỳ cơ sở dữ liệu tương thích nào)

### Hướng dẫn cài đặt

1. **Clone Repository**

   ```bash
   git clone https://github.com/haildnph-31607/asp.net_main.git
   cd asp.net_main
2.Cài đặt các gói NuGet
```bash
   dotnet restore
3.Chạy migration
```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
