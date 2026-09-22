using UnityEngine;

public class PowerUpShiel : MonoBehaviour

{
    public GameObject PowerUpPrefab;
    public Transform player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.CompareTag("Player"))
            {
          Player player = collision.gameObject.GetComponent<Player>();
          player.Invicibility();  

          Destroy(gameObject);
       }
    }
}