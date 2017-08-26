using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject Target;
    public float Speed;
    public float Attack;


	void Update ()
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
            Target.GetComponent<EnemyState>().HP -= Attack;
            Destroy(gameObject);
        }
	}
}
