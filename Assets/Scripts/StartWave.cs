using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartWave : MonoBehaviour {
    public GameObject spawner;
	// Use this for initialization
	void Start () {
		
	}

    public void Button()
    {
        Invoke("startgame", 0.3f);
    }
    private void startgame()
    {
        spawner.GetComponent<EnemySpawn>().IsStart = true;
        Destroy(gameObject);
    }
}


