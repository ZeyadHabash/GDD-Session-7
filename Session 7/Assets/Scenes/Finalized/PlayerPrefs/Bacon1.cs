using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bacon1 : MonoBehaviour
{
    public Text baconCounter;
    public int bacons = 0;

    private void Start()
    {
        bacons = PlayerPrefs.GetInt("Bacons", 0);
    }

    void Update()
    {
        if (bacons == 1)
            baconCounter.text = "you have " + bacons + " bacon";
        else
            baconCounter.text = "you have " + bacons + " bacons";

        PlayerPrefs.SetInt("Bacons", bacons);
    }

    public void incrementBacon()
    {
        bacons++;
    }
}
