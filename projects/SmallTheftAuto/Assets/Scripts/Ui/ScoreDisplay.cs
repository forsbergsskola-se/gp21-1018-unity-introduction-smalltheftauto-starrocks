using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class ScoreDisplay : MonoBehaviour
{
   private PlayerStats _playerStats;
   private Text _text;

   private void Awake()
   {
      _text = GetComponent<Text>();
      _playerStats = GetComponentInParent<PlayerStatsLoader>().playerStats;
   }

   private void LateUpdate()
   {
      _text.text = _playerStats.Score + "pts";
   }
}
