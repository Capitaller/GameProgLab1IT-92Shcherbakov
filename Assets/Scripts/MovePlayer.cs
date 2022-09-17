using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MovePlayer : MonoBehaviour
{
    [SerializeField]

    public Rigidbody2D rb;
    public float jumpAmount = 5;

    public bool playerIsGrounded ;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(
            Input.GetAxis("Horizontal") * 5f * Time.deltaTime,
            Input.GetAxis("Vertical") * 5f * Time.deltaTime, 0f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (playerIsGrounded == true)
              {

                rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
                //playerIsGrounded = false;


            }
            
        }



    }
    private void OnCollisionStay2D(Collision2D Coll)
    {
        if (Coll.gameObject.tag == "Platform")
        {
            playerIsGrounded = true;

        }

            
    }
    private void OnCollisionExit2D(Collision2D Coll)
    {
        if (Coll.gameObject.tag == "Platform")
        {
            playerIsGrounded = false;

        }


    }




}
