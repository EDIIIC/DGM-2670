using UnityEngine;

[CreateAssetMenu(fileNAme = "MovePatternDual")]
public class MovePatternDual : MovePattern
{
	private bool doubleJump;

	public override void Invoke(CharacterController controller, Transform transform)
	{
		if (controller.isGrounded)
		{
			Move(transform);			
			doubleJump = true;
		}
		else
		{
			
			if (doubleJump)
			{
				move(transform);
				doubleJump = false;
			}
		}

		Move(controller);
	}
}
