﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovement : MonoBehaviour
{
    private int direction = 0;
    private float moveSpeed = 2f;
    [SerializeField] private Animator anim;
    [SerializeField] private Rigidbody2D rb;

    private bool isWandering = false;
    private bool isMoving = false;

    IEnumerator Wandering() 
    {
        isWandering = true;

        //Debug.Log("Idling");
        yield return new WaitForSeconds(1f);        // idling time

        direction = Random.Range(1,5); 	            // 1-up, 2-down, 3-left, 4-right
        //direction = 1;

        isMoving = true;
        yield return new WaitForSeconds(1f);        // moving time
        isMoving = false;

        isWandering = false;
    }

    void Update()
    {
        anim.SetFloat("moveSpeedX", Mathf.Abs(rb.velocity.x));
        anim.SetFloat("moveSpeedY", Mathf.Abs(rb.velocity.y));

        if(isWandering == false) {
            StartCoroutine(Wandering());
        }

        if(isMoving == false) 
        {
            //Debug.Log("isMoving: " + isMoving);
            rb.velocity = new Vector2(0.0f, 0.0f);
        }

        if(isMoving == true) {

            switch(direction) {
            case 1: { rb.velocity = new Vector2(0.0f, moveSpeed);                                               // up
                      anim.SetBool("isWalkingUp", true); anim.SetBool("isWalkingDown", false);
                      anim.SetBool("isWalkingLeft", false); anim.SetBool("isWalkingRight", false); 
                      //Debug.Log("Moving up");
                      //Debug.Log("isMoving: " + isMoving); 
                      break; }  
            case 2: { rb.velocity = new Vector2(0.0f, -moveSpeed);                                              // down
                      anim.SetBool("isWalkingUp", false); anim.SetBool("isWalkingDown", true);
                      anim.SetBool("isWalkingLeft", false); anim.SetBool("isWalkingRight", false); 
                      //Debug.Log("Moving down");
                      //Debug.Log("isMoving: " + isMoving); 
                      break; }      
            case 3: { rb.velocity = new Vector2(-moveSpeed, 0.0f);                                               // left
                      anim.SetBool("isWalkingUp", false); anim.SetBool("isWalkingDown", false);
                      anim.SetBool("isWalkingLeft", true); anim.SetBool("isWalkingRight", false);  
                      //Debug.Log("Moving left"); 
                      //Debug.Log("isMoving: " + isMoving);  
                      break; }    
            case 4: { rb.velocity = new Vector2(moveSpeed, 0.0f);                                              // right
                      anim.SetBool("isWalkingUp", false); anim.SetBool("isWalkingDown", false);
                      anim.SetBool("isWalkingLeft", false); anim.SetBool("isWalkingRight", true);  
                      //Debug.Log("Moving right");
                      //Debug.Log("isMoving: " + isMoving); 
                      break; }   
            }



        }
    }

}
