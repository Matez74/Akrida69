using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController2D controller;

    float horizontalmove = 0f;
    public float runSpeed = 40;
    bool jump = false;
    // Update is called once per frame
    void Update()
    {
       horizontalmove =  Input.GetAxisRaw("Horizontal") * runSpeed;
        
        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        
    }
    private void FixedUpdate() 
    {
      controller.Move(horizontalmove * Time.fixedDeltaTime,false,jump);  
      jump = false;
    }
}
