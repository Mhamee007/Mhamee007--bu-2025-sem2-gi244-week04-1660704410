using Unity.Collections;
using UnityEngine;

public class WaveSpawnManager : MonoBehaviour
{   public Wave[] waves;
    public WaveController waveController;

    private int currrentWave;
    void Start()
    {
        currrentWave = 0;
        waveController.ChangeWave(waves[0]);
    }

    void Update()
    {
        if (waveController.isCompleted())
        {
            currrentWave++;
            if (currrentWave < waves.Length)
            {
                waveController.ChangeWave(waves[currrentWave]);
            }
            
        }
    }
}