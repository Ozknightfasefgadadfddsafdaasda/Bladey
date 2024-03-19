// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;


// public class Jumping : MonoBehaviour
// {
//     //Delete this later
//        public float playerSetX;
//        public float playerSetZ;
//        public float playerSetZ;

//     // Start is called before the first frame update
//     void Start()
//     {
       
//        Vector3 Horizontaljump = new float;
//        Horizontal playerJumpHeight = new Vector3;
//     }

//     // Update is called once per frame
//     void Update()
//     {
//          if (Input.GetKeyDown("space") && isGrounded)
//         {
//             transform.position += new Vector3(playerSetX, playerJumpHeight, playerSetZ);
//         }
//           if (isWallRunning)
//   {
//     playerCam.GetComponent<Camera>().fieldOfView = 96;
//     if (Physics.Raycast(transform.position, transform.right, 1f, ground))
//     {
//       rb.velocity += transform.right * 0.1f;
//       if (playerCam.localEulerAngles.z < 15f || playerCam.localEulerAngles.z>345f )
//       {
//         playerCam.localEulerAngles += new Vector3(0, 0, 100f*Time.deltaTime);
//       } 
//     }
//     if (Physics.Raycast(transform.position, -transform.right, 1f, ground))
//     {
//       if (playerCam.localEulerAngles.z >345f)
//       {
//         playerCam.localEulerAngles += new Vector3(0, 0, -100f*Time.deltaTime);
//       }
//       playerCam.localEulerAngles += new Vector3(0, 0, -10f*Time.deltaTime);
//       rb.velocity += transform.right * -0.1f;
//     }
//   }
//   else
//   {
//     playerCam.GetComponent<Camera>().fieldOfView = 90;
//   }
//     }
// }
