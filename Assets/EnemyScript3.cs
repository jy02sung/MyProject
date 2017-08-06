using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript3 : MonoBehaviour
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
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0.0f);
            if (transform.position.x >= -3.6f)
            {
                transform.Rotate(0.0f, 0.0f, -90.0f);
                step = 1;
            }
        }
        else if (step == 1)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, -speed);
            if (transform.position.y <= -1.4f)
            {
                transform.Rotate(0.0f, 0.0f, 90.0f);
                step = 2;
            }
        }
        else if (step == 2)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0.0f);
            if (transform.position.x >= 0.9f)
            {
                transform.Rotate(0.0f, 0.0f, 90.0f);
                step = 3;
            }
        }
        else if (step == 3)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, speed);
            if (transform.position.y >= 3.6f)
            {
                transform.Rotate(0.0f, 0.0f, -90.0f);
                step = 4;
            }
        }
        else if (step == 4)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0.0f);
            if (transform.position.x >= 5.4f)
            {
                transform.Rotate(0.0f, 0.0f, -90.0f);
                step = 5;
            }
        }
        else if (step == 5)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, -speed);
            if (transform.position.y <= -3.2f)
            {
                transform.Rotate(0.0f, 0.0f, 90.0f);
                step = 6;
            }
        }
        else if (step == 6)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0.0f);
            if (transform.position.x >= 9.0f)
            {
                Destroy(gameObject);
            }
        }
    }
}