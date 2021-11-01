using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/Player/Stats", fileName = "Stats")]
public class PlayerStats : ScriptableObject
{
   [SerializeField] private int health;
   [SerializeField] private int money;
   [SerializeField] private int score;

   public int Health => health;
   public float Money => money;
   public float Score => score;

   public void TakeDamage(int damage)
   {
      health -= damage;
   }
}
