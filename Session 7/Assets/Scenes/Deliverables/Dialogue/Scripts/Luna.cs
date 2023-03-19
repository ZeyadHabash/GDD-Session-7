using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luna : MonoBehaviour
{
    public float speed = 5f;
    public float jumpspeed = 5f;
    Rigidbody2D rb;
    Transform tr;
    public int dir;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
        dir = 1;
    }

    void Update()
    {
        float hori = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(hori * speed, rb.velocity.y);
        if (Input.GetKey(KeyCode.A))
            dir = -1;
        if (Input.GetKey(KeyCode.D))
            dir = 1;
        tr.localScale = new Vector3(Mathf.Abs(tr.localScale.x) * dir, tr.localScale.y, tr.localScale.z);
        if (Input.GetKey(KeyCode.Space))
            rb.velocity = new Vector2(rb.velocity.x, jumpspeed);
    }
}
