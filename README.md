Adventure 2D - First Game Project
Đây là dự án game 2D đầu tay của mình, được phát triển bằng Unity 6. Dự án này giúp mình làm quen với quy trình phát triển game, quản lý mã nguồn bằng Git/GitHub và tư duy logic trong lập trình C#.

Các tính năng đã hoàn thiện
Di chuyển vật lý: Nhân vật di chuyển mượt mà bằng Rigidbody2D, xử lý lật mặt (Flip) và giới hạn chỉ dùng phím mũi tên.

Cơ chế Nhảy: Xử lý nhảy đơn và kiểm tra va chạm mặt đất (Ground Check) bằng Tag.

Hệ thống Item: Thu thập trái cây (Dâu, Táo, Chuối...) có hiệu ứng biến mất và tích lũy điểm số.

Quản lý môi trường: Sử dụng Tilemap Collider 2D và Composite Collider để tối ưu hóa va chạm mặt đất.

Công nghệ sử dụng
Engine: Unity 6.

Ngôn ngữ: C#.

Quản lý phiên bản: Git & GitHub Desktop.

Asset: Pixel Adventure của Pixel Frog.

Hình ảnh trong game


https://github.com/user-attachments/assets/8387d819-8ead-4d8c-9a0c-b7f069591037



Góc nhìn Tester (Self-Testing)
Với tư cách là một người định hướng theo QC/Tester, mình đã thực hiện các bài test sau trên dự án:

Kiểm tra va chạm: Đảm bảo nhân vật không bị kẹt vào các cạnh gạch (Sử dụng Physics Material 2D với Friction = 0).

Logic ăn điểm: Đảm bảo mỗi trái cây chỉ được tính điểm một lần và biến mất ngay khi va chạm (Trigger).

Hiệu năng: Tối ưu hóa va chạm bằng Composite Collider 2D để giảm số lượng phép tính vật lý.

Liên hệ
Gmail: dttrangnb1801@gmail.com
