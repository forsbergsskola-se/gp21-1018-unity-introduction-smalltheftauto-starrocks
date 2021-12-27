using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    //Method should be named with capital letter :)
    //Agreed /Felix
    //Seriously WTF Ben. That's some old school code.
    // /Ben
    // TODO: Lol, it's about time that I teach you how to do code review in source control instead of the source code! :D
    // Also, I like these UI components, as they're small and modular.
    public void ExitGame() {
        Application.Quit();
        Debug.Log("Game Quit");
    }
}
