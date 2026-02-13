using System.Data;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    public Transform[] spawnPoint;
    private Wave wave;
    private int spawnEnemies = 0;
    private float nextSpawnTime = 0;

    public void ChangeWave(Wave wave)
    {
        this.wave = wave;
        spawnEnemies = 0;
        nextSpawnTime = Time.time;

    }
    public bool isCompleted()
    { 
        return spawnEnemies >= wave.enemyCount;
    }
    void Update()
    {
        float t = Time.time;
        if (spawnEnemies < wave.enemyCount && t > nextSpawnTime)
        {
            Spawn();
            spawnEnemies++;
            nextSpawnTime = t + wave.spawnInterval;
        }
        
    }

    void Spawn()
    { 
        int enemyIndex = Random.Range(0, wave.enemyPrefabs.Length);
        int pointIndex = Random.Range(0, spawnPoint.Length);

        var prefab = wave.enemyPrefabs[enemyIndex];
        var point = spawnPoint[pointIndex];

        Instantiate(prefab, point.position, Quaternion.Euler(0,180,0));
    }
}
