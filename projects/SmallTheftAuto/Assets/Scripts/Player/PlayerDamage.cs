using UnityEngine;

[RequireComponent(typeof(PlayerStatsLoader))]
 
public class PlayerDamage : MonoBehaviour
{
    [SerializeField] private int dmgAmount;
    [SerializeField] private float timeToTakeDamage;
    
    private PlayerStats _playerStats;
    private float _elapsedTime;
    
    private void Awake()
    {
        _playerStats = GetComponent<PlayerStatsLoader>().playerStats;
        _playerStats.InitializePlayerStats();

        _elapsedTime = timeToTakeDamage;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Water"))
        {
            _playerStats.KillPlayer(gameObject);
        }

        if (other.gameObject.CompareTag("Vehicle"))
        {
            _playerStats.TakeDamage(dmgAmount, gameObject);
        }    
    }

    private void OnTriggerStay(Collider other)
    {
        _elapsedTime += Time.deltaTime;
        
        if (other.gameObject.CompareTag("Fire") && _elapsedTime > timeToTakeDamage)
        {
            _playerStats.TakeDamage(dmgAmount, gameObject);
            _elapsedTime = 0;
        }
    }
}
