using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBehavior : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(sceneBuildIndex:1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(sceneBuildIndex:0);
    }

    public void EndGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
