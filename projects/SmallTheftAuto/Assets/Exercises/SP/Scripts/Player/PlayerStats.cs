using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(menuName = "ScriptableObject/Player/Stats", fileName = "PLayerStats")]
public class PlayerStats : ScriptableObject
{
    [SerializeField] private float _health;
    [SerializeField] private float _money;
    [SerializeField] private int _score;

    public float Health => _health;
    public float Money => _money;
    public int Score => _score;
}
