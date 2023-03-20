using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dynamic_music_script : MonoBehaviour
{
    public bool canSwitch = true;
    public bool firstPhase = true;
    public Audio_struct audios;
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!source.isPlaying)
        {
            canSwitch = true;
            if (firstPhase)
            {
                source.clip = audios.AudioArray[0].rowaud[Random.Range(0,4)];
            }
            else
            {
                source.clip = audios.AudioArray[1].rowaud[Random.Range(0, 4)];
            }
            source.Play();
        }
    }
    public void Switchit()
    {
        if(canSwitch)
            firstPhase = !firstPhase;
        canSwitch = false;
    }
}
