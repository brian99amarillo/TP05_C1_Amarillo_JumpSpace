using System;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameSettingsObtaculeSO obtaculeSO;
    [SerializeField] private Transform player;
    [SerializeField] private GameObject asteroidPrefab;
    [SerializeField] private GameObject powerUpinvisibility;
    [SerializeField] private  float timeSpawnAsteroid = 2f;
    [SerializeField] private float timeSpawnPowerUp = 2f;
    [SerializeField] private float spawnDistanceX = 50f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnObtacule), 0f, timeSpawnAsteroid);
        InvokeRepeating(nameof(SpawnPowerUp), 0f, timeSpawnPowerUp);
    }

    public void SpawnObtacule()     // Spawneo el obstaculo a una distancia de el player  
    {

        float spawnX = player.position.x + spawnDistanceX;
        float spawnY = obtaculeSO.RandomY();
        Vector2 spawnPos = new Vector2(spawnX, spawnY);
        GameObject newAsteroid =  Instantiate(asteroidPrefab, spawnPos, Quaternion.identity);

        Destroy(newAsteroid, 5f);
    }



    public void SpawnPowerUp()
    {
        float spawnX = player.position.x + spawnDistanceX;
        float spawnY = 0;
        Vector2 spawnPos = new Vector2(spawnX, spawnY);
        GameObject newPowerUp = Instantiate(powerUpinvisibility, spawnPos, Quaternion.identity);

        Destroy(newPowerUp, 50f);

    }









}
