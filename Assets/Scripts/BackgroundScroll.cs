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

        Vector2 offset = new Vector2(Time.time * scrollSpeed, 0);

        meshRenderer.material.mainTextureOffset = offset;
    }
}