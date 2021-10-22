using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHealth : MonoBehaviour {
	[SerializeField]private int health;
	[SerializeField]private int maxHealth;
	[SerializeField]private int damage;

	private void Awake() {
		health = maxHealth;
	}
	void TakeDamage(int damage) {
		health -= damage;
		health = Mathf.Clamp(health, 0 , maxHealth);
	}
	private void OnCollisionEnter(Collision other) {
		if (other.gameObject.CompareTag("Vehicle")) {
			TakeDamage(damage);
		}
	}
}
