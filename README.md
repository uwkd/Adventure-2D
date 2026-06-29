# 🎮 ADVENTURE 2D
Dự án được phát triển trong quá trình học tập và nghiên cứu về Unity Engine.

## 🚀 TIẾN ĐỘ PHÁT TRIỂN (ROADMAP)
- [x] **Di chuyển vật lý**: Nhân vật di chuyển mượt mà bằng `Rigidbody2D`.
- [x] **Cơ chế Nhảy**: Kiểm tra va chạm sàn (`Ground Check`) chính xác.
- [x] **Hệ thống Item**: Thu thập trái cây, xử lý va chạm bằng `Trigger`.
- [x] **Quản lý Map**: Sử dụng `Tilemap` để thiết kế màn chơi nhanh chóng.
- [ ] **Giao diện (UI)**: Đang hoàn thiện bảng hiển thị điểm số và Menu chính.

---

## 🛠 CÔNG NGHỆ SỬ DỤNG
* **Engine**: Unity 6
* **Ngôn ngữ lập trình**: C#
* **Quản lý phiên bản**: Git / GitHub Desktop
* **Thiết kế**: Tilemap 2D, Sprites, Animations

---
# BÁO CÁO KIỂM THỬ (TEST REPORT) 
## 1. Phạm vi kiểm thử (Scope of Testing)
* **Đối tượng:** Các tính năng tương tác logic, điều hướng và hệ thống xử lý va chạm cơ bản.
* **Phương pháp:** Manual Testing (Kiểm thử thủ công).

## 2. Kịch bản kiểm thử tiêu biểu (Sample Test Cases)

| Đang test cái gì (Feature) | Các bước thực hiện (Steps) | Kết quả mong đợi (Expected Result) | Trạng thái (Status) |
| :--- | :--- | :--- | :--- |
| **Hệ thống điều hướng** | Nhấn phím di chuyển trái/phải/nhảy | Nhân vật phản hồi mượt mà, đúng hướng | **Passed** |
| **Xử lý va chạm** | Điều khiển nhân vật va chạm với vật cản | Nhân vật bị chặn lại, không xuyên qua vật cản | **Passed** |
| **Kiểm thử vùng biên** | Điều khiển nhân vật di chuyển sát góc tường | Nhân vật dừng lại đúng biên, không bị kẹt tọa độ | **Passed** |

## 3. Nhật ký quản lý lỗi (Bug Log)

* **Bug #01: Lỗi kẹt tọa độ khi rơi tự do tốc độ cao**
  * *Mô tả:* Khi nhân vật rơi từ độ cao lớn sát mép vật cản, hệ thống xử lý va chạm bị chậm dẫn đến nhân vật bị lún/kẹt vào vật cản.
  * *Trạng thái:* **Fixed** (Đã sửa đổi và tối ưu lại logic cập nhật tọa độ trong code).

## 📸 HÌNH ẢNH MINH HỌA


https://github.com/user-attachments/assets/1821b711-b0fb-43a1-8012-3d000d832377



---

## 📬 LIÊN HỆ
* **Họ tên**: Dương Thuỳ Trang
* **Gmail**: dttrangnb1801@gmail.com
* **Linkedln**: [![LinkedIn](https://img.shields.io/badge/LinkedIn-Dương%20Trang-blue?style=for-the-badge&logo=linkedin)](https://www.linkedin.com/in/wkdtomar)
