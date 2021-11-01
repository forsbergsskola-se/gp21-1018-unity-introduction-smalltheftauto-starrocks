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
        if (other.gameObject.CompareTag("Water"))
        {
            _playerStats.InstantDeath();
        }

        if (other.gameObject.CompareTag("Vehicle"))
        {
            _playerStats.TakeDamage(30);
        }    }
}
