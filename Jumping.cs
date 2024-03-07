using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       public float playerSetX;
       public float playerSetZ;
       public float playerSetZ;
       Vector1 = new float;
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
