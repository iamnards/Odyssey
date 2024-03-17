using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() {
        SceneManager.LoadSceneAsync(1);
    }
    public void QuitGame() {
        Application.Quit();
    }
    public void Back() {
        SceneManager.LoadSceneAsync(0);
    } 
}
