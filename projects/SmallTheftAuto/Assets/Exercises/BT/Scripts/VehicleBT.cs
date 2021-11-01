using UnityEngine;

public class VehicleBT : MonoBehaviour
{
	public GameObject player;
	public float minDistance;
    
	void Update()
	{
		if (Input.GetButtonDown("Interact-Vehicle"))
		{
			if (PlayerIsInCar())
			{
				player.GetComponent<DriveAbilityBT>().LeaveCar();
			}
			else if (VehicleInRange())
			{
				player.GetComponent<DriveAbilityBT>().EnterCar();
			}
		} 
	}

	private bool VehicleInRange()
	{
		if (Vector3.Distance(transform.GetChild(0).position, player.transform.position) <= minDistance)
		{
			Debug.Log("In range");
			return true;
		}
		Debug.Log("Not in range");
		return false;
	}
    
	public bool PlayerIsInCar()
	{
		return !player.activeInHierarchy;
	}
}
