using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Vector2 playerInput;   
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private SpriteRenderer sr;

    private float moveSpeed = 6.5f;

    void FixedUpdate()
    {
        playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb.velocity = playerInput.normalized * moveSpeed;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)) sr.flipX = true;
        if(Input.GetKeyDown(KeyCode.D)) sr.flipX = false;
    }
}
