using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    //Method should be named with capital letter :)
    //Agreed /Felix
    //Seriously WTF Ben. That's some old school code.
    // /Ben
    public void ExitGame() {
        Application.Quit();
        Debug.Log("Game Quit");
    }
}
