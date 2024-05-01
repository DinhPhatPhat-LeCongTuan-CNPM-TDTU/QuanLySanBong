29/4, mới xong khung giao diện cơ bản
Thiếu LOGO ở top-left.
Nav bar bên trái:
+Có hiệu ứng (Enter: gần giống hover).
+Chỉ mới bấm được vào Tài khoản, kiểm tra đã đăng nhập chưa, nếu rồi thì vào form thông tin tài khoản, nếu chưa thì vào form đăng nhập, trong đăng nhập có nút chuyển qua form đăng ký (chưa xong, mai sẽ xong).
+Có tạo được lớp mô hình hóa của Khách Hàng.
+Chưa động vào các lớp khác, chỉ mới tạo connection chứ chứ xài.

Mục tiêu tiếp theo: 
  +Hoàn thành đăng nhập đăng ký, chọn quyền đăng nhập.
  +Bắt đầu làm việc với database, trước mắt là với các bảng khách hàng, quản lý.

#################################################################
12:45 AM 5/2
- DTO: đã mô hình hóa KhachHang và QuanLy.
-DAL: KhachHangAccess, QuanLyAccess có các phương thức làm việc với database để kiểm tra tài khoản tồn tại hay không.
-BLL:  KhachHangBLL, QuanLyBLL có các phương thức gọi tới DAL để kiểm tra đăng nhập.
-GUI: 
 +Hoàn thành việc chuển qua lại giữa đăng ký-đăng nhập.
 +Kiểm tra đăng nhập với tư cách KhachHang hay QuanLy và thông báo tùy trường hợp.
 +pictureBox_Show_Hind_Password có thể click vào để hiện, ẩn mật khẩu.

Mục tiêu tiếp theo: Hoàn thành chức năng Đăng Ký, ghi nhớ Đăng Nhập, giao diện Tài Khoản sau khi đăng nhập thành công đối với từng Actors
