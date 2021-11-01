using UnityEngine;

[RequireComponent(typeof(PlayerStatsLoader))]
public class PlayerDamage : MonoBehaviour
{
    private PlayerStats _playerStats;
    
    private void Awake()
    {
        _playerStats = GetComponent<PlayerStatsLoader>().playerStats;
        _playerStats.InitializePlayerStats();
    }

    private void OnCollisionEnter(Collision other)
    {
        _playerStats.TakeDamage(30);
    }
}
