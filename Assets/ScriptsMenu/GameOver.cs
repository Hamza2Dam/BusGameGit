using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
{
    bool isPaused = false;
    public GameObject GameOverCanvas;

    public void Retry() 
    {
        SceneManager.LoadScene("SampleScene"); // Reiniciem la partida/l'escena
    }

    public void Menu()
    {
        SceneManager.LoadScene("MenuPrincipal"); // Menu
    }

    public void Resume()
    {
        GameOverCanvas.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;

    }
    public void Pause()
    {
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;

    }

}
