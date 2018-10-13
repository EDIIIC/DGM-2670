using UnityEngine;

[RequireComponent(typeof(CharacterController))]
	public class OldMoveScript : MonoBehaviour 
	{
/*
		public FloatData jumpSpeed;
		public FloatData gravity;

		public FloatData MoveX, MoveY, MoveZ;
		public FloatData RotX, RotY, RotZ;

		private Vector3 moveDirection;
		private Vector3 rotDirection;

		private CharacterController controller;

		void Start()
		{
			controller = GetComponent<CharacterController>();
		}

		void Update() {
			
			if (CharacterController.isGrounded) {
				moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.value);
				rotDirection.Set(RotX.Value, RotY.Value, RotZ.Value);
				transform.Rotate(rotDirection);
				moveDirection = transform.TransformDirection(moveDirection);

				if (Input.GetButton("Jump"))
					moveDirection.y = jumpSpeed.Value;
			}

			moveDirection.y -= gravity.Value * Time.deltaTime;
			controller.Move(moveDirection * Time.deltaTime);
		}
*/
	}
