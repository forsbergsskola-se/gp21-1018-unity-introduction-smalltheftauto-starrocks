using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyDisplay : MonoBehaviour
{
    private PlayerStats _playerStats;
    private Text _text;
    
    void Start()
    {
        _playerStats = GetComponentInParent<PlayerStatsLoader>().playerStats;
        _text = GetComponent<Text>();
    }

   
    void Update()
    {
        _text.text = "$" + _playerStats.Money;
    }
}
