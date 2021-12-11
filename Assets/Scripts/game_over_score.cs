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
        int landfill = Mathf.Max(0, 7 - Text_points.enemy_recycled);
        score.text = "Score: " + Text_points.total_points + "\n" + Text_points.enemy_recycled + " devices were reused and recycled!" + "\n" + landfill + " devices are contaminating the Earth in the landfill :(";

    }
}
