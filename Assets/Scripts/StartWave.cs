using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartWave : MonoBehaviour {
    public List <GameObject> spawner;
	// Use this for initialization
	void Start () {
		
	}

    public void Button()
    {
        Invoke("startgame", 0.3f);
    }
    private void startgame()
    {
        foreach (GameObject S in spawner)
        {
            S.GetComponent<EnemySpawn>().IsStart = true;
        }
        Destroy(gameObject);
    }
}


