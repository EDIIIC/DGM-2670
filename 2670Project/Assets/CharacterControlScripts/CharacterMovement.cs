using UnityEngine;

//[RequiredComponent(typeof(CharacterController))]

//CharacterMovement = CharacterControlScripts?
public class CharacterMovement : MonoBehavior
{

    private CharacterController controller;
    public MovePattern Pattern

    private void Start() {
        controller = GetComponent<CharacterController>();
    }

    void Update() {
        Pattern().Invoke(controller, transform);
    }
}









/*
[RequireComponent(typeof(CharacterController))]

public class CharacterMovement : MonoBehavior

public float speed = 6.0F;
public float jumpSpeed = 8.0F;
public float gravity = 20.0F;
private Vector3 moveDirection = Vector3.zero;

private CharacterController controller;

private void Start()
{
controller = GetComponent<CharacterController>();
}

void Update() {

if (controller.isGrounded) {
    moveDirection.Set(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
   // moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    moveDirection = transform.TransformDirection(moveDirection);
    moveDirection *= speed;
    if (Input.GetButton("Jump"))
        moveDirection.y = jumpSpeed;
    
}
moveDirection.y -= gravity * Time.deltaTime;
controller.Move(moveDirection * Time.deltaTime);
}
*/