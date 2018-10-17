using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class RomController : MonoBehaviour
{
   CharacterController characterController;

   public float speed = 6.0f;
   public float jumpSpeed = 8.0f;
   public float gravity = 20.0f;

   public FloatData MoveX, MoveY, MoveZ;
   
   public int health;
   public GameObject levelManager;
   
   private Vector3 moveDirection = Vector3.zero;
   private CharacterController controller;

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
         moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.Value);
         moveDirection *= speed;
         if (Input.GetButton("Jump"))
            moveDirection.y = jumpSpeed;
         
      }
      moveDirection.y -= gravity * Time.deltaTime;
      characterController.Move(moveDirection * Time.deltaTime);
   }
}