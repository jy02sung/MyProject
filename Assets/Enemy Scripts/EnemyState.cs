using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : MonoBehaviour {
    public float HP;
    public int Money;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (HP <= 0.0f)
        {
            Destroy(gameObject);
            GameObject.Find("Money").GetComponent<PlayerMoney>().AddMoney(Money);
        }
	}
}
