using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horrible_double_jump_final : MonoBehaviour
{
    int maxjumps = 2;
    public int currjumps;
    Rigidbody2D rb;
    public bool jumping = false;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        currjumps = maxjumps;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !jumping && currjumps > 0)
        {
            jumping = true;
            anim.SetBool("jump", true);
        }
        anim.SetFloat("y-velocity", rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumping = false;
        currjumps = maxjumps;
        anim.SetBool("Grounded", true);
    }

    public void jump()
    {
        rb.velocity = Vector2.up * 10;
        currjumps--;
        anim.SetBool("jump", false);
        anim.SetBool("Grounded", false);
    }

    public void allowjump()
    {
        jumping = false;
    }
}
