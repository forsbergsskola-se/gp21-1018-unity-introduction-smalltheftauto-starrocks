using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    //Method should be named with capital letter :)
    //Agreed /Felix
    public void doExitGame() {
        Application.Quit();
        Debug.Log("Game Quit");
    }
}
