using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameSP : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("GameSP");
    }
}
