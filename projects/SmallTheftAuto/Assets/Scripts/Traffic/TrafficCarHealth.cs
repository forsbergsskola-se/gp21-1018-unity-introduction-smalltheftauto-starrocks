using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(PlayerStatsLoader))]
public class TrafficCarHealth : MonoBehaviour
{
    [SerializeField] protected int health;
    [SerializeField] protected int maxHealth;
    [SerializeField] protected int damage;

    public int Health => health;
    
    private protected PlayerStats _playerStats;
    
    private void Awake()
    {
        _playerStats = GetComponent<PlayerStatsLoader>().playerStats;
        
        health = maxHealth;
    }

    private void LateUpdate()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
            _playerStats.Score += damage;
        }
    }
    
    // TODO: Sure, that you need to check for ParticleCollision here?
    private void OnParticleCollision(GameObject other)
    {
        TakeDamage(damage);
    }

    public void TakeDamage(int damage) 
    {
        health -= damage;
        health = Mathf.Clamp(health, 0 , maxHealth);
    }
}
