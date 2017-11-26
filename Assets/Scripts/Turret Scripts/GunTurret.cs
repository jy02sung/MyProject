using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunTurret : MonoBehaviour
{
    public float Attack;
    public float AttackSpeed;
    public float AttackRange;
    float time;
    public GameObject Bullet;

	void Update ()
    {
        time += Time.deltaTime;
        if (time >= 1.0f / AttackSpeed)
        {
            time = 0.0f;
            GameObject[] Enemy = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject e in Enemy)
            {
                if (Vector2.Distance(transform.position, e.transform.position) <= AttackRange)
                {
                    Vector3 direction = e.transform.position - transform.position;
                    float Angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                    transform.eulerAngles = new Vector3(0.0f, 0.0f, Angle - 90);
                    GameObject Instance = Instantiate(Bullet);
                    Instance.transform.position = transform.position;
                    Instance.GetComponent<Bullet>().Target = e;
                    Instance.GetComponent<Bullet>().Attack = Attack;
                    break;
                }
            }
        }
	}
}
