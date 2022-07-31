using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 offset;
    public GameObject turret;
    private Renderer rend;
    private Color startColor;
    [HideInInspector]
    public Costos costos;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    public Vector3 posicionConst()
    {
        return transform.position + offset;
    }

    public void SellTurret()
    {
        Destroy(turret);
    }

    void OnMouseDown()
    {
        if (turret != null)
        {
            Debug.Log("Ya hay una torre");
            BuildManager.instance.SelectNode(this);
            return;
        }

        if (!BuildManager.instance.contruccion)
        {
            return;
        }

        BuildManager.instance.Contruir(this);
    }

    void OnMouseEnter()
    {
        if (!BuildManager.instance.contruccion)
        {
            return;
        }
        rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
