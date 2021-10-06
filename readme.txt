                                 __ 		  __    _ _ _ _ _ __    _ _ _ _ _ __    _ _ _ _ _ _ __
|  |                  /\        |  \         /  |  |   _ _ _ _ _   |   _ _ _ _ _   |   _ _ _ __   |  
|  |                 /  \       |   \       /   |  |  |            |  |            |  |        |  |
|  |                /    \      |    \     /    |  |  |            |  |            |  |        |  |
|  |               /  /\  \     |  \  \   /  /  |  |  |_ _ _ _ _   |  |            |  |        |  |
|  |              /  /__\  \    |  |\  \ /  /|  |  |  |_ _ _ _ _   |  |            |  |        |  |
|  |			 /  /____\  \   |  | \     / |  |  |  |            |  |            |  |        |  |
|  | _ _ _ _ _  /  /      \  \  |  |  \   /  |  |  |  |_ _ _ _ _   |  |_ _ _ _ __  |  |_ _ _ __|  |
|  _ _ _ _ _ _ /  /        \  \ |  |   \ /   |  |  |_ _ _ _ _ __   |_ _ _ _ _ _ _  |_ _ _ _ _ _ __|

trang web mẫu sẵn, đã chuẩn bị những thứ sau đây:
- Mẫu cấu trúc MVC kết hợp repository dễ sửa chữa và bảo trì.
- Tích hợp sẵn các công cụ Entity Framework.
- Thay đổi connectionstring trong file appsettings.
- Tích hợp sẵn init migration: gõ [dotnet ef database update] để khởi tạo cơ sở dữ liệu ban đầu
- Cấu hình sẵn file startup theo mô hình MVC tại router.
- Đưa sẵn viewstart, viewport, layout vào chỉ cần sửa lại theo ý mình.
- Có vài mẫu Class có sẵn bạn chỉ việc sửa lại theo ý mình
===============================================================================================
- Đã Cài đặt webpack để đóng gói css,js,scss thành js.min,css.min  (cần phải cài đặt trước npm)
- sử dụng lệnh [npm run build] hoặc [npm run watch] để build thành file js hoặc css tự động
- Chỉnh sửa file các scss trong src/scss/
- Chỉnh sửa file js trong src/scss/
- Chỉnh sửa watch trong package.json
- Chỉnh sửa đường dẫn hoặc thêm bớt file scss trong webpack.config.js
===============================================================================================
- Đã cài đặt gulp.js (máy sử dụng phải có nodejs)
- gulp build các file SCSS ở đường dẫn [assets] thành css lưu kết quả tại wwwroot/css/, sau đó tối ưu hóa lưu tại wwwroot/css/min/
- thi hành tác vụ gulp: [gulp sass] hoặc [gulp](default) xem trong file gulpfile.js để xem nó chạy cái gì, hoặc cấu hình thêm trong đó



_________________________________________________________________
_________________________________________________________________
_________________________________________________________________
_________________________________________________________________
_________________________________________________________________
_______________  ^         /   /       \    ^     _______________
______________  Lam Eco chuc cac ban thanh cong !  ______________
________________                  .               _______________
_________________________________________________________________
_________________________________________________________________
_________________________________________________________________
_________________________________________________________________
_________________________________________________________________

