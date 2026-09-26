using UnityEngine;

public class Parallax : MonoBehaviour
{
    //[SerializeField] private GameObject ObjectBackground;
    [SerializeField] private Vector2 velocity;

    private Vector2 offset;
    private Material material;

    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
    }
    private void Update()
    {
        offset = velocity * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
