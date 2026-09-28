using UnityEngine;

public class PowerUpLifeExtra : MonoBehaviour
{
    static public float counter = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && counter < 3)
        {
            counter++;
            UILife.Instance.UpdateHearts((int)counter);
            Destroy(gameObject);
        }
    }
}