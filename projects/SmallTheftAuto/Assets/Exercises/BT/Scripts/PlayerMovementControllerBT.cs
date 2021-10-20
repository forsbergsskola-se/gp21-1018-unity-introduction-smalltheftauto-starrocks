using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class PlayerMovementControllerBT : MonoBehaviour {
	public GameObject player;
	void Update() {
		if (Input.GetKey(KeyCode.LeftShift)) {
			transform.Translate(0f, 7.5f * Time.deltaTime * Input.GetAxis("Vertical"), 0f);
		}
		transform.Translate(0f, 5f * Time.deltaTime * Input.GetAxis("Vertical"), 0f);
		transform.Translate(2.5f * Time.deltaTime * Input.GetAxis("Horizontal"), 0f, 0f);
		transform.Rotate(0f, 0f, -180f * Time.deltaTime * Input.GetAxis("Rotate"));
		transform.Rotate(0f, 0f, -180f*Time.deltaTime*Input.GetAxis("Rotate2"));
	}
}
