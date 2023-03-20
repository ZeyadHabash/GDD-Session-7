using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Bacon b;
    float c = 0;
    void Update()
    {
        c = b.bacons;
        if (c < 256)
            gameObject.GetComponent<SpriteRenderer>().color = new Color(c/510, c/510, c/510);
    }
}
