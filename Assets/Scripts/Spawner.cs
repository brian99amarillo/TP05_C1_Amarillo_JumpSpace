using System;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameSettingsObtaculeSO obtaculeSO;
    public Transform player;
    public GameObject asteroidPrefab;
    public float timeSpawn = 2f;
    public float spawnDistanceX = 20f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnObtacule), 0f, timeSpawn);
    }

    public void SpawnObtacule()     // Spawneo el obstaculo a una distancia de el player  
    {

        float spawnX = player.position.x + spawnDistanceX;
        float spawnY = obtaculeSO.RandomY();
        Vector2 spawnPos = new Vector2(spawnX, spawnY);
        GameObject newAsteroid =  Instantiate(asteroidPrefab, spawnPos, Quaternion.identity);

        Destroy(newAsteroid, 10f);
    }
}
