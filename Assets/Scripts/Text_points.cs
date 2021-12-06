using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_points : MonoBehaviour
{
    public you_won_game you_won;
    public static int total_points = 0;
    Text text_points;

    // Start is called before the first frame update
    void Start()
    {
        text_points = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text_points.text = "Points: " + total_points.ToString();
        if (Player.you_won)
        {
            you_won.Setup();
        }
    }
}
