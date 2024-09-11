using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Loaded Main Menu");
    }
    public void playGame()
    {
        Debug.Log("Loadad Level 1");
        SceneManager.LoadSceneAsync("Level1");
    }
    public void quitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void openHighScores()
    {
        Debug.Log("Loadad High Scores");
        SceneManager.LoadSceneAsync("HighScores");
    }
    public void openOptions()
    {
        Debug.Log("Loadad Options");
        SceneManager.LoadSceneAsync("Options");
    }
    public void backToMain()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
