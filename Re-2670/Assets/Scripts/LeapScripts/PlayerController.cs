using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
   CharacterController characterController;

   public float speed;
   public float jumpSpeed;
   public float gravity;
   private Vector3 moveDirection = Vector3.zero;
   //public AudioSource audioSource;

   private CharacterController controller;

   void Start()
   {
      controller = GetComponent<CharacterController>();
   }

   void Update()
   {
      if (controller.isGrounded)
      {       
         moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
         moveDirection = transform.TransformDirection(moveDirection);
         moveDirection = moveDirection * speed;
         if (Input.GetButton("Jump"))
         {
            moveDirection.y = jumpSpeed;
         }
      }
      else
      {
//       Left/Right movement in mid air allowed
         moveDirection.x = Input.GetAxis("Horizontal") * speed;
      }
      moveDirection.y -= gravity * Time.deltaTime;
      
      controller.Move(moveDirection * Time.deltaTime);
   }
}
























/*SECOND
[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
   CharacterController characterController;

   public float speed = 6.0f;
   public float jumpSpeed = 8.0f;
   public float gravity = 20.0f;
   public int health;
   public GameObject levelManager;
   private Vector3 moveDirection = Vector3.zero;

   void Start()
   {
      characterController = GetComponent<CharacterController>();
      // \/
      print(GetComponent<Health>().GetHealth());
   }

   
   void Update()
   {
      if (characterController.isGrounded)
      {
         moveDirection.Set(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
         moveDirection *= speed;
         if (Input.GetButton("Jump"))
            moveDirection.y = jumpSpeed;
         
      }
      moveDirection.y -= gravity * Time.deltaTime;
      characterController.Move(moveDirection * Time.deltaTime);
   }
}
*/

/*
 FIRST
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{

   public float thrusterForce;

   private Rigidbody rigid;
   public int health;
   public float moveSpeed;
   public GameObject levelManager;


   void Start()
   {
      rigid = GetComponent<Rigidbody>();
      print(GetComponent<Health>().GetHealth());
   }

   void Update()
   {

      if (Input.GetKey(KeyCode.Space))
      {
         rigid.AddRelativeForce(new Vector2(0f, thrusterForce));

         //KEYS TO MOVE
         float h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
         float v = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

         transform.Translate(new Vector3(h, v, 0f));
      }
   }
}
*/
