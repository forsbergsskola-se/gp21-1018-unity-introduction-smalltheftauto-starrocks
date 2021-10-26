using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyDisplay : MonoBehaviour {
	private PlayerStats _playerStats;
	private Text _text;

	private void Awake() {
		_text = GetComponent<Text>();
		_playerStats = GetComponentInParent<PlayerStatsLoader>().playerStats;
	}

	private void LateUpdate() {
		_text.text = "$" + _playerStats.Money;
	}
}
