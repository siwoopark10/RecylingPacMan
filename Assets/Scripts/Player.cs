using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool you_won = false;

    public Pause pause;

    Rigidbody2D rb;

    Vector2 direction;

    float speed = 3f;

    public bool edible = false;

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

        if (GameObject.FindWithTag("point") == null)
        {
            you_won = true;
            SoundManager.PlaySound("win");
        }

        if (Input.GetKey(KeyCode.Escape) == true)
        {
            pause.SetUp();
        }

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

    public void edible_false()
    {
        edible = false;
    }

    public void edible_true()
    {
        edible = true;
        Invoke("edible_false", 5.0f);
        //Debug.Log(edible);
    }

    

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if(col.gameObject.tag == "Item")
        {
            if (!edible)
            {
                edible_true();
            }
        }
    }
}
