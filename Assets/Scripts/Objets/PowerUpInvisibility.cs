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
        UITimer.Instance.PanelActived();

        while (timePowerUp > 0f)
        {
            UITimer.Instance.TimerON(timePowerUp);
            yield return null;
            timePowerUp -= Time.deltaTime;
        }

        UITimer.Instance.PanelDisable();
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Asteroid"), false);
        activedInvincibility = false;
    }

}