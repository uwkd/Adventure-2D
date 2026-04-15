using UnityEngine;

public class Fruit : MonoBehaviour
{
    [SerializeField] private int scoreValue = 1; // Số điểm cộng thêm khi ăn

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kiểm tra xem thứ vừa chạm vào mình có phải là Player không
        if (collision.CompareTag("Player"))
        {
            // Sau này Trang sẽ gọi hàm tăng điểm từ một Script quản lý điểm ở đây
            Debug.Log("Đã ăn trái cây! Cộng: " + scoreValue + " điểm.");

            // Xóa quả dâu đi
            Destroy(gameObject);
        }
    }
}