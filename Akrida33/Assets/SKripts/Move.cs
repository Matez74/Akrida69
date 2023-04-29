using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
  public float speed;
    public float jump;
    Rigidbody2D rb;

    public Transform groundCheck;
    public LayerMask groundLayer;
    bool isGounded;


    private void Start() 
    {
        rb=GetComponent<Rigidbody2D>();
    }
   
    void Update()
     {
          Movement();
     }

      private void Movement()
     {
          float speed2 = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
          transform.Translate(speed2, 0, 0);


            isGounded = Physics2D.OverlapCapsule(groundCheck.position,new Vector2(1.8f,0.3f),CapsuleDirection2D.Horizontal,0,groundLayer);

          if(Input.GetButtonDown("Jump") && isGounded == true)
          {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
          }
     }
}
