using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_over_score : MonoBehaviour
{
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + Text_points.total_points;
    }
}
