using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bacon : MonoBehaviour
{
    public Text baconCounter;
    public int bacons = 0;

    void Update()
    {
        if (bacons == 1)
            baconCounter.text = "you have " + bacons + " bacon";
        else
            baconCounter.text = "you have " + bacons + " bacons";
    }

    public void incrementBacon()
    {
        bacons++;
    }
}
