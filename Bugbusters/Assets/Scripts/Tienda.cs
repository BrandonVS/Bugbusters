using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tienda : MonoBehaviour
{
    public Costos torre1Prefab;
    public Costos torre2Prefab;
    public Costos torre3Prefab;
    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }
    
    public void torreta1()
    {
        Debug.Log("Torr1");
        buildManager.torreSeleccionada(torre1Prefab);
    }

    public void torreta2()
    {
        Debug.Log("2");
        buildManager.torreSeleccionada(torre2Prefab);
    }

    public void torreta3()
    {
        Debug.Log("3");
        buildManager.torreSeleccionada(torre3Prefab);
    }
}
