using UnityEngine;

public class CarMovementBT : MonoBehaviour
{
	[SerializeField][Range(1f, 30f)]float moveSpeed = 20f;
	[SerializeField][Range(0f, -360f)]float rotateSpeed = -180f;
	void Update()
	{
		CarMove();
	}

	void CarMove()
	{
		transform.Translate(0f, moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"), 0);
		transform.Rotate(0f, 0,rotateSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
	}
}
