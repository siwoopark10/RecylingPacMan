using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class you_won_game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Setup()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0;

    }

    public void play_again()
    {
        LIves.num_lives = 3;
        Text_points.total_points = 0;
        Player.you_won = false;
        gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;

    }
}
