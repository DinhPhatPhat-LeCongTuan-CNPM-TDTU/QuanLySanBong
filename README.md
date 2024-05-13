- 29/4, mới xong khung giao diện cơ bản
- Thiếu LOGO ở top-left.
- Nav bar bên trái:
  + Có hiệu ứng (Enter: gần giống hover).
  + Chỉ mới bấm được vào Tài khoản, kiểm tra đã đăng nhập chưa, nếu rồi thì vào form thông tin tài khoản, nếu chưa thì vào form đăng nhập, trong đăng nhập có nút chuyển qua form đăng ký (chưa xong, mai sẽ xong).
  + Có tạo được lớp mô hình hóa của Khách Hàng.
  + Chưa động vào các lớp khác, chỉ mới tạo connection chứ chứ xài.

- Mục tiêu tiếp theo: 
  + Hoàn thành đăng nhập đăng ký, chọn quyền đăng nhập.
  + Bắt đầu làm việc với database, trước mắt là với các bảng khách hàng, quản lý.

- #################################################################
- 12:45 2/5
- DTO: đã mô hình hóa KhachHang và QuanLy.
- DAL: KhachHangAccess, QuanLyAccess có các phương thức làm việc với database để kiểm tra tài khoản tồn tại hay không.
- BLL:  KhachHangBLL, QuanLyBLL có các phương thức gọi tới DAL để kiểm tra đăng nhập.
- GUI: 
  + Hoàn thành việc chuển qua lại giữa đăng ký-đăng nhập.
  + Kiểm tra đăng nhập với tư cách KhachHang hay QuanLy và thông báo tùy trường hợp.
  + pictureBox_Show_Hind_Password có thể click vào để hiện, ẩn mật khẩu.

- Mục tiêu tiếp theo: Hoàn thành chức năng Đăng Ký, ghi nhớ Đăng Nhập, giao diện Tài Khoản sau khi đăng nhập thành công đối với từng Actors

- #################################################################
- 20:00 6/5
- DTO: đã mô hình hóa OTP
- DAL: OTPAccess
- BLL: OTP_BLL
- GUI: 

- Mục tiêu tiếp theo: trang chủ
- #################################################################

- 19:00 7/5
- GUI: 
  + Trang chủ, kiểm tra logic thanh điều hướng form con sau khi đăng nhập
  + Giao diện đặt sân
- Mục tiêu tiếp theo: chức năng đặt sân

- #################################################################
- 17:40 8/5
- DTO: mô hình hóa PhieuDatSan, ChiTietPhieuDatSan
- DAL: PhieuDatSanAccess
- BLL: PhieuDatSan_BLL
- GUI: 
  + Cải thiện giao diện đặt sân với sơ đồ 12 sân bóng và làm nổi bật các sân được chọn để đặt sân
  + Đã có thể đặt sân và thêm phiếu đặt sân vào cơ sở dữ liệu (Bảng PhieuDatSan)

- Mục tiêu tiếp theo: 
  + ChiTietPhieuDatSan
  + Kiểm tra lịch đăng ký và ngăn chặn đăng ký nếu trùng, thời điểm đăng ký trong quá khứ
  + Form XemLichDaDangKy hiển thị những khung giờ đã bị đăng ký trong từng ngày

- #################################################################
- 23:59 8/5
- DAL: ChiTietPhieuDatSanAccess
- BLL: ChiTietPhieuDatSan_BLL
- GUI: 
  + Khi đặt sân đã thêm dữ liệu vào PhieuDatSan và ChiTietPhieuDatSan

- Mục tiêu tiếp theo: 
  + Kiểm tra lịch đăng ký và ngăn chặn đăng ký nếu trùng, thời điểm đăng ký trong quá khứ
  + Form XemLichDaDangKy hiển thị những khung giờ đã bị đăng ký trong từng ngày

- #################################################################
- 00:16 10/5
- DAL: cập nhật: ChiTietPhieuDatSanAccess, PhieuDatSanAccess, OTPAcess, KhachHangAccess
- BLL: ChiTietPhieuDatSan_BLL, PhieuDatSan_BLL, OTP_BLL, KhachHang_BLL
- GUI: 
  + Kiểm tra lịch đăng ký và ngăn chặn đăng ký nếu trùng, thời điểm đăng ký trong quá khứ
  + Form XemLichDaDangKy hiển thị những khung giờ đã bị đăng ký trong từng ngày
  + Form TaiKhoanNguoiDung hiện lên khi người dùng đăng nhập bằng tài khoản người dùng
  + Trong TaiKhoanNguoiDung có thể xem lịch sử đặt sân của người đó
  + Trong TaiKhoanNguoiDung có thể chỉnh sửa thông tin người dùng
  + Đăng xuất sau khi đăng nhập
  + Đổi mật khẩu bằng OTP qua email
  + Form TaiKhoanQuanLy (Chưa hoàn thành)
- Mục tiêu tiếp theo: 
  + Hoàn thiện Form TaiKhoanQuanLy, gồm các chức năng : QuanLyDatSan, QuanLyTaiKhoanHeThong, DieuChinhGiaSan, ThongKeKinhDoanh (In ấn)

- 01:1 13/5
- Còn một chức năng in ấn thống kê khinh doanh là xong

- 05:34 13/5
- Hoàn thành.