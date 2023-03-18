using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horrible_double_jump : MonoBehaviour
{
    int maxjumps = 2;
    int currjumps;
    Rigidbody2D rb;
    bool jumping = false;

    // Start is called before the first frame update
    void Start()
    {
        currjumps = maxjumps;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !jumping && currjumps > 0)
        {
            jumping = true;
            //animate your jump
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumping = false;
        currjumps = maxjumps;
    }

    public void jump()
    {
        rb.velocity = Vector2.up * 10;
        currjumps--;
    }

    public void allowjump()
    {
        jumping = false;
    }
}
