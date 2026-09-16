using UnityEngine;

public class ObtaculeMovement : MonoBehaviour
{
    [SerializeField] private GameSettingsObtaculeSO ObtaculeSO;
    private Rigidbody2D rb;
    private Vector2 starPosObtacule;
    public float speedObtacule;
    private float RandomX;
    private float RandomY;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        starPosObtacule = ObtaculeSO.startPosition;
        transform.position = starPosObtacule;
    }


    private void Update()
    {
        rb.AddForce(new Vector2(-speedObtacule, 0f));
    }
}
