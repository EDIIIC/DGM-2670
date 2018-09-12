using UnityEngine;

[CreateAssetMenu]
public class MovePattern : ScriptableObject {

    public float gravity;
    
    public FloatData MoveX, MoveY, MoveZ;
    public FloatData RotX, RotY, RotZ;

    private Vector3 moveDirection;
    private Vector3 rotDirection;

    public virtual void Invoke(CharacterController controller, Transform transform)
    {
        if (controller.isGrounded)
        {
            Move(transform)
        }

        Move(controller)
    }

    protected void Move(CharacterController controller)
    {
        moveDirection.y -= gravity.Value * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
        {
            
    moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.value);
            rotDirection.Set(RotX.Value, RotY.Value, RotZ.Value);
            transform.Rotate(rotDirection);
            moveDirection = transform.TransformDirection(moveDirection);
        }
        moveDirection.y -= gravity.Value * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime); 
    }
}
