using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerMovement : MonoBehaviour
{
    private Vector2 playerInput;   
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator anim;

    private float moveSpeed = 3f;

    void FixedUpdate()
    {
        playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb.velocity = playerInput.normalized * moveSpeed;
    }


    void Update()
    {
        anim.SetFloat("moveSpeedX", Mathf.Abs(rb.velocity.x));
        anim.SetFloat("moveSpeedY", Mathf.Abs(rb.velocity.y));

        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetBool("isWalkingUp", true);
            anim.SetBool("isWalkingDown", false);
            anim.SetBool("isWalkingLeft", false);
            anim.SetBool("isWalkingRight", false);
        }       

        if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetBool("isWalkingUp", false);
            anim.SetBool("isWalkingDown", true);
            anim.SetBool("isWalkingLeft", false);
            anim.SetBool("isWalkingRight", false);
        }

        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetBool("isWalkingUp", false);
            anim.SetBool("isWalkingDown", false);
            anim.SetBool("isWalkingLeft", true);
            anim.SetBool("isWalkingRight", false);
        }

        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetBool("isWalkingUp", false);
            anim.SetBool("isWalkingDown", false);
            anim.SetBool("isWalkingLeft", false);
            anim.SetBool("isWalkingRight", true);
        }
    }
}
