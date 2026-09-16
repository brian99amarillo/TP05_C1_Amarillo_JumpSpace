using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    [SerializeField] private GameSettingsPlayerSO playerSO;
    public float fuerzasalto;
    private Rigidbody2D rb;
    private Vector2 starPos;
    private bool jump = false;
    private bool jumpInprogress = false;
private void Awake()
    {
     rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        starPos = playerSO.startPosition;
        transform.position = starPos;
    }
    private void Update()       
    {
        if (Input.GetKeyDown(KeyCode.Space) && !jump) { jumpInprogress = true; }    // Chequeo si se apreta el boton de salto y que el player no este saltando
    }
    private void FixedUpdate()
    {   
        if (jumpInprogress)
        {
            rb.AddForce(new Vector2(0, fuerzasalto),ForceMode2D.Impulse);   // impulso al player hacia el eje Y
            jump = true;
            jumpInprogress = false;
                Debug.Log("salto");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.gameObject.CompareTag("Platform") && jump)    // Si el player esta colisionando con la plataforma se reinicia el jump
        {
            jump = false;
        }
    }
}
