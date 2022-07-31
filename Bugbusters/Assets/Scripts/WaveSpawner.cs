using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform bugPrefab1;
    public Transform bugPrefab2;
    public Transform bugPrefab3;
    public Transform inicio;
    

    public float intermedio = 3f;
    private float countdown = 3f;
    public static int oleada = 1;

    private Transform bug;
    private Transform bugPrefab;

    float tempIntervalo;
    void Start() 
    {
        tempIntervalo = Random.Range(0.2f, 0.9f);
    }
    void Update()
    {

        if (countdown <= 0f)
        {
            float intervaloBugs = Random.Range(0.2f, 0.7f);
            int numeroBugs = Random.Range(2, 6);
            StartCoroutine(ApareceBug(numeroBugs, intervaloBugs));

            countdown = Random.Range(2f, 5f);
        }

        countdown -= Time.deltaTime;
    }


    IEnumerator ApareceBug(int numeroBugs, float intervaloBugs)
    {
        if(oleada >= 20)
        {
            yield break;
        }
        int tipoBug = Random.Range(1, 4);
        
        switch (tipoBug)
        {
            case 1:
                bugPrefab = bugPrefab1;
                break;
            case 2:
                bugPrefab = bugPrefab2;
                break;
            case 3:
                bugPrefab = bugPrefab3;
                break;
            default:
                break;
        }
        oleada++;
        float interval = Random.Range(0.2f, 0.8f);
        for (int i = 0; i < numeroBugs; i++)
        {
            bug = Instantiate(bugPrefab, inicio.position, inicio.rotation);

            yield return new WaitForSeconds(interval);
        }
    }
}
