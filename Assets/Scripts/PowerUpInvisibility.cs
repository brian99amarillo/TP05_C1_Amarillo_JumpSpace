using System.Collections;
using UnityEngine;

public class PowerUpInvisibility : MonoBehaviour

{
    [SerializeField] private GameObject PowerUpPrefab;
    [SerializeField] private Transform player;

    private float timePowerUp = 5f;
    public static bool activedInvincibility = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.CompareTag("Player"))
       {
          Player player = collision.gameObject.GetComponent<Player>();
          player.StartCoroutine(InvicibilityRoutine());


            Destroy(gameObject);
       }
    }
    private IEnumerator InvicibilityRoutine()
    {
        activedInvincibility = true;
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Asteroid"), true);

        yield return new WaitForSeconds(timePowerUp);

        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Asteroid"), false);
        activedInvincibility = false;
    }




}