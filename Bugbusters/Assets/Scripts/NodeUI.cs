using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeUI : MonoBehaviour
{
    private Node target;

    public GameObject ui;

    public void SetTarget(Node _target)
    {
        target = _target;

        transform.position = target.posicionConst();

        ui.SetActive(true);
    }

    public void Hide()
    {
        ui.SetActive(false);
    }

    public void Vender()
    {
        target.SellTurret();
        BuildManager.instance.DeselectNode();
    }
}
