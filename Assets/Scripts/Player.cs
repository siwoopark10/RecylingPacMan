using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;

    Vector2 direction;

    float speed = 3f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveDirection();

        Vector2 translation = direction * speed * Time.fixedDeltaTime;

        rb.MovePosition(rb.position + translation);
    }

    private void MoveDirection()
    {
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            // check if we can move up
            direction = new Vector2(-1, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            direction = new Vector2(1, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            direction = new Vector2(0, 1);
        }
        else if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            direction = new Vector2(0, -1);
        }
    }
}
