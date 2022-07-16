using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform bugPrefab;
    public Transform inicio;
    public Text oleadaN;

    public float intermedio = 3f;
    private float countdown = 3f;
    private int oleada = 1;

    private Transform bug;

    void Update()
    {
        if (countdown <= 0f)
        {
            float intervaloBugs = Random.Range(0.2f, 0.7f);
            int numeroBugs = Random.Range(2, 4);
            StartCoroutine(ApareceBug(numeroBugs, intervaloBugs));
            countdown = intermedio;
        }

        countdown -= Time.deltaTime;


        oleadaN.text = "Oleada: " + oleada.ToString();
    }

    IEnumerator ApareceBug(int numeroBugs, float intervaloBugs)
    {

        for (int i = 0; i < numeroBugs; i++)
        {
            bug = Instantiate(bugPrefab, inicio.position, inicio.rotation);

            yield return new WaitForSeconds(0.2f);
        }
        oleada++;
    }
}
