using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Multiple build manager");
            return;
        }
        instance = this;
    }

    private Costos turretToBuild;
    private Node nodoSeleccionado;

    public NodeUI nodeUI;

    public bool contruccion { get { return turretToBuild != null;  } }

    public void Contruir(Node node)
    {
        if (PlayerStats.dinero < turretToBuild.costo)
        {
            Debug.Log("No hay dinero");
            return;
        }

        PlayerStats.dinero -= turretToBuild.costo;

        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.posicionConst(), Quaternion.identity);
        node.turret = turret;

        Debug.Log("Dinero restante " + PlayerStats.dinero);
    }

    public void SelectNode(Node node)
    {

        if (nodoSeleccionado == node)
        {
            DeselectNode();
            return;
        }

        nodoSeleccionado = node;
        turretToBuild = null;

        nodeUI.SetTarget(node);
    }

    public void torreSeleccionada(Costos turret)
    {
        turretToBuild = turret;
        DeselectNode();
    }

    public void DeselectNode()
    {
        nodoSeleccionado = null;
        nodeUI.Hide();
    }
}
