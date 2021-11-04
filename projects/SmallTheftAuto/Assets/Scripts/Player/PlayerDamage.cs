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
            _playerStats.KillPlayer(gameObject);
        }

        if (other.gameObject.CompareTag("DullVehicle"))
        {
            _playerStats.TakeDamage(30, gameObject);
        }    
    }
}
