using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footstep_script : MonoBehaviour
{
    public AudioClip[] steps = new AudioClip[2];
    AudioSource audio;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    public void step()
    {
        if (Random.Range(0, 2) == 0)
        {
            audio.PlayOneShot(steps[0]);
        }
        else
        {
            audio.PlayOneShot(steps[1]);
        }
    }
}
