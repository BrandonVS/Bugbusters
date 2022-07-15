using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform bugPrefab;

    public float intermedio = 3f;
    private float countdown = 3f;

    void Update()
    {
        if (countdown <= 0f)
        {
            SpawnWave();
            countdown = intermedio;
        }

        countdown -= Time.deltaTime;
    }

    // Update is called once per frame
    void SpawnWave()
    {
        Debug.Log("The bugs are comming");
    }
}
