using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed;
    int step = 0;
    void Start()
    {

    }

    void Update()
    {
        if (step == 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, speed);
            if (transform.position.y >= 1.6f)
            {
                transform.Rotate(0.0f, 0.0f, -90.0f);
                step = 1;
            }
        }
        else if (step == 1)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0.0f);
            if (transform.position.x >= 4.8f)
            {
                transform.Rotate(0.0f, 0.0f, -90.0f);
                step = 2;
            }
        }
        else if (step == 2)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, -speed);
            if (transform.position.y <= -5.5f)
            {
                Destroy(gameObject);
            }
        }
    }
}