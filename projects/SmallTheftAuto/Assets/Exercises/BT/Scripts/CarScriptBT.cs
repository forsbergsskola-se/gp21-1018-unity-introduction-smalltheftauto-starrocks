//
// using UnityEngine;
// using UnityEngine.Serialization;
//
// public class CarScriptBT : MonoBehaviour
// {
// 	[SerializeField] GameObject player;
// 	[SerializeField][Range(0.1f, 100f)] private float minDistanceToEnterCar = 5f;
// 	CarMovementBT carMovementBT;
//     
// 	void Start()
// 	{
// 		carMovementBT = GetComponent<CarMovementBT>();
// 		carMovementBT.enabled = false;
// 	}
//     
// 	void Update()
// 	{
// 		// float distance = DistanceToNearestCar();
// 		// if (Input.GetKeyDown(KeyCode.E)&&distance <= minDistanceToEnterCar) EnterCar(player.gameObject.active);
// 	}
//
// 	void EnterCar(bool isPlayerActive)
// 	{ 
// 		carMovementBT.enabled = isPlayerActive;
// 		player.gameObject.SetActive(!isPlayerActive);
// 	}
//
// 	float DistanceToNearestCar()
// 	{
// 		float distance = Vector3.Distance(transform.position, player.transform.position);
// 		return distance;
// 	}
// }
