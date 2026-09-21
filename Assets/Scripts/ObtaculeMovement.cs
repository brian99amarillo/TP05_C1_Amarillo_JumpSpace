using UnityEngine;

public class ObtaculeMovement : MonoBehaviour
{
    [SerializeField] private GameSettingsObtaculeSO ObtaculeSO;
    private Rigidbody2D rb;
    public float speedObtacule;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
       rb.linearVelocity = new Vector2(-speedObtacule, rb.linearVelocity.y);
    }
}
