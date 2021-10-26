using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    private PlayerStats _playerStats;
    private Image _image;

    private void Awake()
    {
        _playerStats = GetComponentInParent<PlayerStatsLoader>().playerStats;
        _image = GetComponent<Image>();
    }

    private void LateUpdate()
    {
        ScaleHealthBar();
        ChangeColor();
    }

    private void ScaleHealthBar()
    {
        float health = _playerStats.Health;
        Vector3 scaleHealthBar = new Vector3(health / 50, 0.2f, 1);
        transform.localScale = scaleHealthBar;
    }

    private void ChangeColor()
    {
        if (_playerStats.Health < 25) _image.color = Color.red;
        else if (_playerStats.Health < 50) _image.color = Color.yellow;
        else _image.color = Color.green;
    }
}
