using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade_script : MonoBehaviour
{
    float fadeCenter = 0;
    float initialdist;
    public SpriteRenderer filter;
    Color color;
    // Start is called before the first frame update
    void Start()
    {
        color = filter.color;
        initialdist = Mathf.Abs(transform.position.x - fadeCenter);
    }

    // Update is called once per frame
    void Update()
    {
        color.a = Mathf.Lerp(1, 0, (Mathf.Abs(transform.position.x - fadeCenter)) / initialdist);
        filter.color = color;
    }
}
