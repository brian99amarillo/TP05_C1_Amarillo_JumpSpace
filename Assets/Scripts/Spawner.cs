using System;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameSettingsObtaculeSO obtaculeSO;
    public GameObject asteroidPrefab;
    public float timeSpawn = 5f;
    public Transform player;
    public float spawnDistanceX = 15f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnObtacule), 0f, timeSpawn);
    }

    public void SpawnObtacule()
    {

        float spawnX = player.position.x + spawnDistanceX;
        float spawnY = obtaculeSO.RandomY();
        Vector2 spawnPos = new Vector2(spawnX, spawnY);
        GameObject newAsteroid =  Instantiate(asteroidPrefab, spawnPos, Quaternion.identity);

        Destroy(newAsteroid, 10f);
    }
}
