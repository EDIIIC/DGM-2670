using UnityEngine;


[CreateAssetMenu(fileName = "MovePatternDual")]
public class MovePatternDual : MovePattern
{
	private bool doubleJump;

	public override void Invoke(CharacterController controller, Transform transform)
	{
		if (controller.isGrounded)
		{
			MoveTran(transform);			
			doubleJump = true;
		}
		else
		{
			
			if (doubleJump)
			{
				MoveTran(transform);
				doubleJump = false;
			}
		}

		MoveCon(controller);
	}
}
