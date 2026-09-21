using UnityEngine;

public class PowerUpShiel : MonoBehaviour

{
    public GameObject PowerUpPrefab;
    public Transform player;
    private bool activedShield = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PowerUpActived()
        }
    }

    public void PowerUpActived()
    {
      activedShield = true;
    }


}