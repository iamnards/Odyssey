using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 0.5f;
    
    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));

    }
    public void LoadAbout()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 2));

    }
    public void LoadAbout2()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));

    }
    public void AboutExit()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 2));

    }

    public void LoadGuide()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 3));

    }
    public void GuideExit()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 3));

    }
    public void LoadPrevLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
    
    public void Reload() {
        SceneManager.LoadScene(1);
    }
    
    public void QuitGame() {
        Application.Quit();
    }
    
}
