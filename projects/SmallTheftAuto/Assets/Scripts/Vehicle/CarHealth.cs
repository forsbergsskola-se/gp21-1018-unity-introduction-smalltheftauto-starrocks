using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(PlayerStatsLoader))]
public class CarHealth : MonoBehaviour {
	[SerializeField] int health;
	[SerializeField] int maxHealth;
	[SerializeField] int wallDamage;
	[SerializeField] int vehicleDamage;
	[SerializeField] int weaponDamage;
	[SerializeField] int burningThresholdHealth = 60;
	private PlayerStats _playerStats;

	public int Health => health;
	
	private void Awake() {
		health = maxHealth;
		_playerStats = GetComponent<PlayerStatsLoader>().playerStats;
	}

	private void LateUpdate()
	{
		if (health <= 0) {
			CarExplodes();
			Destroy(this.gameObject);
		}
	}

	private void OnCollisionEnter(Collision other) {
		if (other.gameObject.CompareTag("Wall")) {
			TakeDamage(wallDamage);
			CarBurns();
		}
		else if (other.gameObject.CompareTag("Vehicle")) {
			TakeDamage(vehicleDamage);
			CarBurns();
		}
		
		else if (other.gameObject.CompareTag("Water")) { 
			Destroy(this.gameObject);
			_playerStats.KillPlayer(gameObject);
		}
	}

	private void OnParticleCollision(GameObject other)
	{
		TakeDamage(weaponDamage);
	}

	public void TakeDamage(int damage) {
		health -= damage;
		health = Mathf.Clamp(health, 0 , maxHealth);
	}

	void CarExplodes() {
		Debug.Log("iExploded");
		if (GetComponent<Vehicle>().PlayerIsInCar())
		{
			_playerStats.KillPlayer(gameObject);
		}
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
