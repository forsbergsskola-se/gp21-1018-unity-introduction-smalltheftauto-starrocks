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

   public void TakeDamage(int damage, GameObject player )
   {
      Health -= damage;
      if (Health == 0) {
         KillPlayer(player);
      }
   }

   public void InitializePlayerStats()
   {
      health = maxHealth;
   }

   public void KillPlayer(GameObject player) {
      Health = 0;
      Destroy(player);
      Debug.Log("I DIED!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
      //Add Death Screen
   }
}
