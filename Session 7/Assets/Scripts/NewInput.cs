using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class NewInput : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpSpeed = 3f;

    float direction;

    private Rigidbody2D playerBody;
    private bool grounded = true;

    void Awake()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
            grounded = true;
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
            grounded = false;
    }
}

