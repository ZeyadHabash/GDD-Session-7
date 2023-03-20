using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene_script_final : MonoBehaviour
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
        if (Input.anyKey && !played)
        {
            vp.Play();
            played = true;
        }
        if(vp.frame > 1 && !vp.isPlaying)
        {
            vp.gameObject.SetActive(false);
        }
    }
}
