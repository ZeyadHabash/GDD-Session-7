using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene_script : MonoBehaviour
{
    UnityEngine.Video.VideoPlayer vp;
    bool played = false;
    // Start is called before the first frame update
    void Start()
    {
        vp = GetComponent<UnityEngine.Video.VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey && !played)
        {
            played = true;
            //play video
        }
        //check if video isn't playing anymore
    }
}
