using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverScreen;
    bool GameHasEnded = false;

    public void GameOver()
    {
        if (GameHasEnded == false)
        {
            GameOverScreen.SetActive(true);
            GameHasEnded = true;
        }
    }
    
}
