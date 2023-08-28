--------------------------------------------------------------
TÓM TẮT:
----------------------------------------------------------------------------------------------------

- Kiểm tra, giám sát/thông báo cho người sử dụng biết liệu thư mục cần kiểm soát có sự thay đổi.
- Phần mềm có thể sử dụng được trên SQL Server
- Mô hình Client - Server, tạo tên miền mới trên Server để các client sử dụng.

-----------------------------------------------------------------
-------------------------------------------------------------------------------



- Form MDIParent1 - Admin: (username: admin) Quản lý tất cả, có nhiều lựa chọn hơn MDIParent2
- Form MDIParent2 - Client: Giống với MDIParent1 nhưng có một số các tính năng hạn chế (không thể Tạo user mới, EventLog)
- Form Login: Có thể đăng nhập vào sử dụng MDIParent1 & MDIParent2
- Form Register: Tính năng của MDIParent 
- Form EvLog: (EventLog) Tính năng của MDIParent
- Form FileSystemMonitor: (IDS) Tính năng của MDIParent
- Form NewPass: (Đổi mật khẩu) Tính năng của MDIParent

-----------------------------------------------------------------------------------------------------------

- Project đã được build thành file setup, Client tải về và cài đặt sử dụng như một ứng dụng thông minh.

-----------------------------------------------------------------------------------------------------------
CƠ CHẾ:
-----------------------------------------------------------------------------------------------------------
- Client tải ứng dụng IDS về với tên username, password nhà cung cấp đã cấp
- Trên máy tính windows 10 của Client, sau khi join vào domain của Windows Server (laptrinhantoan.com) > tại Client 
mở SSMS (SQL Server Management Studio) > Tìm tên SQL Server của máy Server (SERVER\SQLEXPRESS) > Connect > Login vào 
user nhà cung cấp đã cấp > sẽ thành công nếu Form Login chuyển hướng tới Form MDIParent




