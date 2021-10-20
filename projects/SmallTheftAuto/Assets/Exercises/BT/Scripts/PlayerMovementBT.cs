using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class PlayerMovementBT : MonoBehaviour {
	public GameObject player;
    void Update() {
	    if (Input.GetKey(KeyCode.LeftShift)) {
		    transform.Translate(0f, 7.5f * Time.deltaTime * Input.GetAxis("Vertical"), 0f);
	    }
	    transform.Translate(0f, 5f * Time.deltaTime * Input.GetAxis("Vertical"), 0f);
	    transform.Translate(2.5f * Time.deltaTime * Input.GetAxis("Horizontal"), 0f, 0f);

	    Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
	    Vector3 dir = Input.mousePosition - pos;
	    float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
	    if (dir == player.transform.position) {
		    transform.rotation = Quaternion.AngleAxis(angle - 0f, Vector3.forward);
	    }
	    else {
		    transform.rotation = Quaternion.AngleAxis(angle - 90f, Vector3.forward);
	    }
    }
}
