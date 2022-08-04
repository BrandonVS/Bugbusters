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

    public static int puntaje;
    public int puntajeInicial = 0;

    public Text oleadaN;
    public Text dineroRest;
    public Text vidasRest;
    public Text puntajeFin;
    public Text puntajeWin;
    void Start()
    {
        dinero = dineroInicial;
        Lives = startLives;
    }

    void Update()
    {
        oleadaN.text = "Bugs: " + WaveSpawner.oleada.ToString();
        dineroRest.text = dinero.ToString() + "$";
        vidasRest.text = "Life left: " + Lives.ToString();
        puntajeFin.text = puntajeWin.text = puntaje.ToString();
    }
}
