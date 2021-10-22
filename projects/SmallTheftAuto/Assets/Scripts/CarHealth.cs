using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHealth : MonoBehaviour {
	private int health;
	private int maxHealth;
	
	public int Health {
		get;
	}
	
	void TakeDamage(int damage) {
		health -= damage;
		health = Mathf.Clamp(health, 0 , maxHealth);
	}
}
