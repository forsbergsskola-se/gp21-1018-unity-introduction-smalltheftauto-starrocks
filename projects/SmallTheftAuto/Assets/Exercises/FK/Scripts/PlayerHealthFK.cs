using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthFK : MonoBehaviour
{
    private int health;
    private int maxHealth = 99;
    private TextMeshProUGUI tmp;
    public int Health
    {
        get { return health; }
    }
    void Start()
    {
        health = maxHealth;
        tmp = GetComponent<TextMeshProUGUI>();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = health.ToString();
    }
}
