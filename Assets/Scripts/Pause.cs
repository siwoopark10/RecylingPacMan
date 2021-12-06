using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void SetUp()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
