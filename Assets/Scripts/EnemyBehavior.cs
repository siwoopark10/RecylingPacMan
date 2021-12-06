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
        }

        Vector2 translation = direction * speed * Time.fixedDeltaTime;

        prevPos = rb.position;

        rb.MovePosition(prevPos + translation);

        //Debug.Log(edible);

    }

    Vector2 GetRandomDirection()
    {
        int randomIndex = Random.Range(0, 4);
        return directions[randomIndex];

    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("it got here");
        if (collision.collider.tag == "Player")
        {
            var destroy_enemy = collision.collider.gameObject.GetComponent<Player>().edible;
            //Debug.Log(destroy_enemy);
            if (destroy_enemy)
            {
                //Debug.Log("destroy enemy");
                SoundManager.PlaySound("enemyEaten");
                gameObject.transform.position = new Vector2(0, 0);
            }
            else
            {
                //Debug.Log("loose live");
                LIves.num_lives -= 1;
                SoundManager.PlaySound("playerHit");
                direction = direction *-1;
                
            }
        }

        
    }
}
