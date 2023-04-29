using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{

   
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
           transform.gameObject.tag = "Acctive";
        }
        
        
        if(gameObject.tag == "Acctive")
            Debug.Log("yess");


    }
    private void LateUpdate() 
    {
    transform.gameObject.tag = "neAcctive"; 
    }
}
