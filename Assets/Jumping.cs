using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Jumping : MonoBehaviour
{
    //Delete this later
       public float playerSetX;
       public float playerSetZ;
       public float playerSetZ;

    // Start is called before the first frame update
    void Start()
    {
       
       Vector3 Horizontaljump = new float;
       Horizontal playerJumpHeight = new float;
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown("space") && isGrounded)
        {
            transform.position += new Vector3(playerSetX, playerJumpHeight, playerSetZ);
        }
    }
}
