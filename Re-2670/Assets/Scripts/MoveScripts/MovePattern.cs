using UnityEngine;

[CreateAssetMenu]
public class MovePattern : ScriptableObject 
{ 
    public FloatData JumpSpeed;
    public FloatData Gravity;
    
    public FloatData MoveX, MoveY, MoveZ;
    public FloatData RotX, RotY, RotZ;

    private Vector3 moveDirection;
    private Vector3 rotDirection;

    public virtual void Invoke(CharacterController controller, Transform transform)
    {
        if (controller.isGrounded)
        {
            MoveTran(transform);
        }

        MoveCon(controller);
    }

    protected void MoveCon(CharacterController controller)
    {
        moveDirection.y -= Gravity.Value;
        controller.Move(moveDirection * Time.deltaTime);
    }

    protected void MoveTran(Transform transform)
    {
        moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.value);
        rotDirection.Set(RotX.Value, RotY.Value, RotZ.Value);
        transform.Rotate(rotDirection);
        moveDirection = transform.TransformDirection(moveDirection);
    }
}








/*
// BROKEN
using UnityEngine;

[CreateAssetMenu]
public class MovePattern : ScriptableObject 
{ 
    public FloatData JumpSpeed;
    public FloatData Gravity;
    
    public FloatData MoveX, MoveY, MoveZ;
    public FloatData RotX, RotY, RotZ;

    private Vector3 moveDirection;
    private Vector3 rotDirection;

    public virtual void Invoke(CharacterController controller, Transform transform)
    {
        if (controller.isGrounded)
        {
            Move(transform);
        }

        Move(controller);
    }

    protected void Move(CharacterController controller)
    {
        Move(controller);
       // moveDirection.y -= gravity.Value * Time.deltaTime;
       // controller.Move(moveDirection * Time.deltaTime);
    }

    protected void Move(Transform transform)
    {
        moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.value);
        rotDirection.Set(RotX.Value, RotY.Value, RotZ.Value);
        transform.Rotate(rotDirection);
        moveDirection = transform.TransformDirection(moveDirection);
    }

}
*/