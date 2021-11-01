using System;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/Player/Stats", fileName = "Stats")]
public class PlayerStats : ScriptableObject
{
   [SerializeField] private int health;
   [SerializeField] private int money;
   [SerializeField] private int score;
   [SerializeField] private int minHealth;
   [SerializeField] private int maxHealth;

   
   public int Health
   {
      get => health;
      set
      {
         health = value;
         health=Mathf.Clamp(health, minHealth, maxHealth);
      }
   }
   
   public float Money => money;
   public float Score => score;

   public void TakeDamage(int damage)
   {
      Health -= damage;
   }

   public void InitializePlayerStats()
   {
      health = maxHealth;
   }
   public void InstantDeath() {
      Health = 0;
   }
}
