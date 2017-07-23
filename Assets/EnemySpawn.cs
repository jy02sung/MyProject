using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {
    public GameObject Enemy;
    public float SpawnTime;
    public float WaitTime;
    float time;
    public int wave;
    int EnemyNumber;
    public bool IsStart = false;

	void Update ()
    {
        if (!IsStart)
        {
            return;
        }
        time += Time.deltaTime;
        if (EnemyNumber <= wave)
        {
            if (time >= SpawnTime)
            {
                EnemyNumber += 1;
                Instantiate(Enemy);
                time = 0.0f;
            }
        }
        else
        {
            if (time >= WaitTime)
            {
                EnemyNumber = 0;
            }
        }
	}
}
