using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverScreen;

    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
