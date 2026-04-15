using UnityEngine;

public class Fruit : MonoBehaviour
{
    [SerializeField] private int scoreValue = 1; 

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {

            Debug.Log("Đã ăn trái cây! Cộng: " + scoreValue + " điểm.");

            Destroy(gameObject);
        }
    }
}