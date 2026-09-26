using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameSettingsPlayerSO playerSO;
    [SerializeField] private GameObject CanvasGameOver;
    [SerializeField] private ControllerMusic controllerMusic;
    
    
    private Rigidbody2D rb;
    private Vector2 starPos;
    private float speedPlayer1;
    private float fuerzasalto = 10;
    private bool jump = false;
    private bool jumpInprogress = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        starPos = playerSO.StartPosition;
        transform.position = starPos;
        speedPlayer1 = playerSO.Speed;
    }
    private void Update()
    {
        rb.linearVelocity = new Vector2(speedPlayer1, rb.linearVelocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && !jump) { jumpInprogress = true; }    // Chequeo si se apreta el boton de salto y que el player no este saltando

    }
    private void FixedUpdate()
    {
        if (jumpInprogress)
        {
            rb.AddForce(new Vector2(0, fuerzasalto), ForceMode2D.Impulse);   // impulso al player hacia el eje Y
            jump = true;
            jumpInprogress = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform") && jump)    // Si el player esta colisionando con la plataforma se reinicia el jump
        {
            jump = false;
        }
        {
            if (collision.gameObject.CompareTag("Asteroid") && !PowerUpInvisibility.activedInvincibility)    // Si el player colisiono con el obtaculo se termina el juego
            {   
                GameOver();
            }
        }
    }

    private void GameOver()
    {
        controllerMusic.PauseMusicGameplay();
        CanvasGameOver.SetActive(true);
        Time.timeScale = 0f;
    }
}