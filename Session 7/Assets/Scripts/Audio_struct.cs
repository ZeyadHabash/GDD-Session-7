using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Audio_struct 
{
    [System.Serializable]
    public struct AudioRow
    {
        public AudioClip[] rowaud;
    }
    public AudioRow[] AudioArray = new AudioRow[2]; 
}
