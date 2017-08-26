using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunTurret : MonoBehaviour
{
    public float Attack;
    public float AttackSpeed;
    public float AttackRange;
    float time;
    public GameObject Bullet;

    void Update()
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
