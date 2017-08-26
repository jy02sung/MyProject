using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    public GameObject Target;
    public float Speed;
    public float Attack;
    public float Range;

    void Update()
    {
        if (Target == null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 dir = Target.transform.position - transform.position;
        dir.Normalize();
        dir *= Speed;
        transform.Translate(dir * Time.deltaTime);
        if (Vector2.Distance(transform.position, Target.transform.position) <= 0.1f)
        {
            GameObject[] Enemy = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject e in Enemy)
            {
                if (Vector2.Distance(transform.position, e.transform.position) <= Range)
                {
                    e.GetComponent<EnemyState>().HP -= Attack;
                }
            }
            Destroy(gameObject);
        }
    }
}
