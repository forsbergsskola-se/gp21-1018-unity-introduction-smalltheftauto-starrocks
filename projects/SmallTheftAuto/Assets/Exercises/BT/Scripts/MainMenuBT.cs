using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBT : MonoBehaviour {
	public GameObject restartGame;
	public GameObject close;
	public void MainMenu() {
		restartGame.SetActive(true);
		close.SetActive(true);
	}
	public void MainMenuClose() {
		restartGame.SetActive(false);
		close.SetActive(false);
	}
}
