[Nhóm 3] ĐỒ ÁN CUỐI KỲ MÔN PHÁT TRIỂN ỨNG DỤNG DESKTOP
Đồ án cuối kỳ môn Phát triển ứng dụng Desktop xây dựng một hệ thống quản lý chung cư với đối tượng sử dụng chính là ban quản lý. Hệ thống bao gồm các chức năng chính sau:

Đăng nhập: Cho phép người dùng truy cập hệ thống bằng tên đăng nhập và mật khẩu.
Chăm sóc cư dân: Quản lý các khiếu nại của cư dân và cho phép ban quản lý phản hồi các khiếu nại.
Quản lý tiện ích: Thêm, sửa, xóa các tiện ích trong chung cư như bể bơi, phòng gym, khu vui chơi, v.v.
Quản lý dịch vụ thẻ: Thực hiện các thao tác CRUD (Create, Read, Update, Delete) đối với các loại thẻ trong chung cư.
Quản lý căn hộ: Thêm, sửa, tìm kiếm thông tin về các căn hộ, trạng thái sử dụng, v.v. Cùng với việc theo dõi các khoản phí liên quan đến căn hộ.
Quản lý tài khoản: Thêm, sửa thông tin tài khoản người dùng.
Quản lý cư dân đại diện: Thực hiện các thao tác CRUD và quản lý danh sách cư dân đại diện cho mỗi căn hộ trong chung cư.
Quản lý khoản phí: CRUD và theo dõi các khoản phí có trong chung cư.
Thông báo: CRUD và gửi thông báo về các sự kiện, lịch bảo trì, v.v.
Đăng xuất: Đăng xuất khỏi hệ thống.
Hướng Dẫn Cài Đặt và Chạy Dự Án
Bước 1: Tạo Cơ Sở Dữ Liệu
Mở SQL Server Management Studio.
Chạy các script Create Table và Insert Data trong thư mục CSDL để tạo cơ sở dữ liệu cần thiết cho hệ thống.
Bước 2: Clone Dự Án
Truy cập liên kết GitHub của dự án.
Chọn mục <> Code → Chọn Open with Visual Studio để tải dự án về máy tính của bạn.
Bước 3: Cấu Hình Kết Nối Cơ Sở Dữ Liệu
Mở Visual Studio.
Tìm đến file DBconnect.cs trong thư mục DAL.
Cập nhật tên máy chủ trong chuỗi kết nối (connection string) của đối tượng SQLConnection sao cho phù hợp với cấu hình máy của bạn.
Bước 4: Chạy Dự Án
Mở Visual Studio và chạy dự án.
Sử dụng thông tin đăng nhập sau:
Tên đăng nhập: nhom3
Mật khẩu: 123456
[Group 3] FINAL PROJECT FOR DESKTOP APPLICATION DEVELOPMENT COURSE
The final project for the Desktop Application Development course aims to build a condominium management system with administrative users as the primary operators. The system includes the following main functions:

Login: Allows users to access the system using a username and password.
Resident Care: Manage resident complaints and enable administrators to respond to them.
Facility Management: Add, edit, and delete condominium facilities such as swimming pools, gyms, playgrounds, etc.
Card Service Management: Perform CRUD (Create, Read, Update, Delete) operations on various types of cards used in the condominium.
Apartment Management: Add, edit, and search for apartment details, including usage status, and view the fees associated with each apartment.
Account Management: Add and edit user account information.
Representative Resident Management: Perform CRUD operations and manage the list of resident representatives for each apartment in the condominium.
Fee Management: CRUD and track fees within the condominium.
Notifications: CRUD and send notifications about events, maintenance schedules, etc.
Logout: Log out from the system.
Instructions for Setting Up and Running the Project
Step 1: Create the Database
Open SQL Server Management Studio.
Run the Create Table and Insert Data scripts from the CSDL folder to create the required database for the system.
Step 2: Clone the Project
Access the GitHub link for the project.
Select the <> Code section → Choose Open with Visual Studio to clone the project to your local machine.
Step 3: Configure Database Connection
Open Visual Studio.
Locate the DBconnect.cs file in the DAL folder.
Update the server name in the connection string of the SQLConnection object to match your machine's configuration.
Step 4: Run the Project
Open Visual Studio and run the project.
Use the following login credentials:
Username: nhom3
Password: 123456
