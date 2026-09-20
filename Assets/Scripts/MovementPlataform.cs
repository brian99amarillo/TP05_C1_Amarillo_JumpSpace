using UnityEngine;

public class MovementPlataform : MonoBehaviour
{
    [SerializeField] private GameSettingsPlataformSO plataformSO;
    private Rigidbody2D rb;
    private float speed = 5f;
    private Vector2 starPos;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        starPos = plataformSO.startPosition;
        transform.position = starPos;
        speed = plataformSO.speed;
    }

    private void Update()
    {
         rb.linearVelocity = new Vector2(speed, rb.linearVelocity.y);
    }
}
