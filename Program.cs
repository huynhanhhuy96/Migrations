using System;

namespace Migrations
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Migration : code => database
            Webdb
            */

            /*
            dotnet ef migrations add MigrationName
            -- WebContextModelSnapshot: Chứa cấu trúc database ở thời điểm tạo Migration
            -- _V0Designer: Chứa cấu trúc database ở thời điểm tạo Migration
            -- _V0: Up(migrationBuilder) -> Được thực thi khi sử dụng EF cập nhập cấu trúc V0 lên database
                    Down(migrationBuilder) -> Phục hồi, hủy bỏ cập nhập của 1 phiên bản
            
            dotnet ef migrations list
            dotnet ef migrations remove - remove last migration
            dotnet ef migrations script
            dotnet ef migrations script MigrationName1 MigrationName2
            dotnet ef migrations script -o migrations.sql
            
            dotnet ef database update - update all migration đến last migration
            dotnet ef database update MigrationName - update or back về phiên bản migration
            dotnet ef database drop -f - xóa toàn bộ database
            
            dotnet ef dbcontext scaffold -o Models -d "sqlConnectstring" "Microsoft.EntityFrameworkCore.SqlSever"
            */
        }
    }
}
