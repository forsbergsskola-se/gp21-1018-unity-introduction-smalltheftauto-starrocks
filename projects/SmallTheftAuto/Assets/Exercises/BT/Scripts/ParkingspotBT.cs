using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkingspotBT : MonoBehaviour {
	public bool hasCar;
	public GameObject carPrefab;

	private void Start() {
		if (hasCar == true) {
			SpawnCar();
		}
	}
	void SpawnCar() {
		Instantiate(carPrefab, new Vector3(12, -10, 0), Quaternion.Euler(0,0,0));
	}
}
