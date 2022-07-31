using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public static int dinero;
    public int dineroInicial = 100;

    public static int Lives;
    public int startLives = 20;

    public Text oleadaN;
    public Text dineroRest;
    public Text vidasRest;
    void Start()
    {
        dinero = dineroInicial;
        Lives = startLives;
    }

    void Update()
    {
        oleadaN.text = "Oleada: " + WaveSpawner.oleada.ToString();
        dineroRest.text = dinero.ToString() + "$";
        vidasRest.text = "Vidas restantes: " + Lives.ToString();

    }
}