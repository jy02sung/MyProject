using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupPoint : MonoBehaviour
{
    bool IsSetup;
    public void OnMouseDown()
    {
        if (TowerManager.Instance.Index == -1)
            return;
        if (IsSetup)
            return;
        IsSetup = true;
        GameObject Tower = Instantiate(TowerManager.Instance.Info[TowerManager.Instance.Index].Tower);
        Tower.transform.position = transform.position;
    }
}
