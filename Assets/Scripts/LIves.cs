using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LIves : MonoBehaviour
{
    public Game_Over GameOver;
    public static int num_lives = 3;
    Text lives;
    // Start is called before the first frame update
    void Start()
    {
        lives = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        lives.text = "Lives: " + num_lives.ToString();
        if (num_lives <= 0)
        {
            game_is_over();
        }
    }

    void game_is_over()
    {
        GameOver.Setup();
        Time.timeScale = 0;
    }
}
