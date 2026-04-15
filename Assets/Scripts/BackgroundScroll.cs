using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    private MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        // Tính toán độ lệch của ảnh theo thời gian
        Vector2 offset = new Vector2(Time.time * scrollSpeed, 0);
        // Cập nhật nó vào Material của vật thể
        meshRenderer.material.mainTextureOffset = offset;
    }
}