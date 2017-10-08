using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupPoint : MonoBehaviour
{
    public GameObject Money;
    bool IsSetup;
    public void OnMouseDown()
    {
        if (TowerManager.Instance.Index == -1)
            return;
        if (IsSetup)
            return;
        
        if (Money.GetComponent<PlayerMoney>().SubtractMoney(TowerManager.Instance.Info[TowerManager.Instance.Index].Price))
        {
            IsSetup = true;
            GameObject Tower = Instantiate(TowerManager.Instance.Info[TowerManager.Instance.Index].Tower);
            Tower.transform.position = transform.position;
        }
    }
}
