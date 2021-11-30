using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    Rigidbody2D rb;

    Vector2 direction;

    Vector2 prevPos;

    float speed = 3f;

    List<Vector2> directions = new List<Vector2>() {new Vector2(0,1), new Vector2(1,0), new Vector2(-1,0), new Vector2(0,-1) };

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = new Vector2(0, 1);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (prevPos != null && prevPos == rb.position)
        {
            direction = GetRandomDirection();
            Debug.Log("here");
        }

        Vector2 translation = direction * speed * Time.fixedDeltaTime;

        prevPos = rb.position;

        rb.MovePosition(prevPos + translation);
        
    }

    Vector2 GetRandomDirection()
    {
        int randomIndex = Random.Range(0, 4);
        return directions[randomIndex];

    }
}
