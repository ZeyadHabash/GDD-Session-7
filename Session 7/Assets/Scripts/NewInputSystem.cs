using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class NewInputSystem : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpSpeed = 3f;

    float direction;

    private Rigidbody2D playerBody;
    private bool grounded = true;
    private PlayerInput playerInput;
    private InputAction jumpAction;
    private InputAction moveAction;

    void Awake()
    {
        playerBody = GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>();
        jumpAction = playerInput.actions["Jump"];
        moveAction = playerInput.actions["Move"];

    }

    private void jump(InputAction.CallbackContext context)
    {
        if (grounded)
            playerBody.velocity = new Vector2(playerBody.velocity.x, jumpSpeed);
    }

    private void move(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<float>();
    }
    private void stopMove(InputAction.CallbackContext context)
    {
        direction = 0;
    }
    void OnEnable()
    {
        playerInput.enabled = true;
        jumpAction.performed += jump;
        moveAction.performed += move;
        moveAction.canceled += stopMove;
    }
    private void OnDisable() {
        playerInput.enabled = false;
        jumpAction.performed -= jump;
        moveAction.performed -= move;
        moveAction.canceled -= stopMove;
    }

    private void Update() {
        playerBody.velocity = new Vector2(direction * moveSpeed, playerBody.velocity.y);
        transform.localScale = new Vector3(Mathf.Sign(direction), 1, 1);

        // if (Keyboard.current.spaceKey.wasPressedThisFrame)
        //     jump(new InputAction.CallbackContext());
        // if(jumpAction.triggered)
        //     jump(new InputAction.CallbackContext());
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

