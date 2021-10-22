using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHealth : MonoBehaviour {
	[SerializeField] int health;
	[SerializeField] int maxHealth;
	[SerializeField] int damage;
	[SerializeField] int burningThresholdHealth = 60;

	private void Awake() {
		health = maxHealth;
	}
	void TakeDamage(int damage) {
		health -= damage;
		health = Mathf.Clamp(health, 0 , maxHealth);
	}
	private void OnCollisionEnter(Collision other) {
		if (other.gameObject.CompareTag("Vehicle")||other.gameObject.CompareTag("Wall")) {
			TakeDamage(damage);
			CarBurns();
			if (health <= 0) {
				Destroy(this.gameObject);
				CarExplodes();
				
			}
		}
	}
	void CarExplodes() {
		Debug.Log("iExploded");
		if (GetComponent<Vehicle>().PlayerIsInCar())
		{
			Destroy(GetComponent<Vehicle>().player.gameObject);
			//Destroy(GameObject.Find("Player"));
			Debug.Log("I DIED!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
		}
		//whateverfancysmancystyff.
		//add Michael Bay...
	}

	void CarBurns()
	{
		if (health <= burningThresholdHealth)
		{
			//health -= firedamage
			Debug.Log("Car is on fire");
		}
	}
}
