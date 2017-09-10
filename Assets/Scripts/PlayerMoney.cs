using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoney : MonoBehaviour
{
    public int Money;
    public Text MoneyText;

	// Use this for initialization
	void Start ()
    {
        Money=10;
	}
    public void AddMoney(int MoneyToAdd)
    {
        Money += MoneyToAdd;
    }
    public bool SubtractMoney(int Price)
    {
         if(Money - Price < 0)
         {
            Debug.Log("Insufficient Funds");
            return false;
         }
         else
         {
             Money -= Price;
            return true;
         }
    }

    void Update()
    {
        MoneyText.text = Money.ToString();
    }
}
