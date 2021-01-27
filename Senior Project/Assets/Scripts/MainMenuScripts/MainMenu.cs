using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject parentMainMenu;
    public GameObject settingsMenu;
    public GameObject creditsMenu;
    public GameObject FadeScreen;

    public GameObject Credits { get => creditsMenu; set => creditsMenu = value; }

    public void PlayGame()
    {
        FadeScreen.GetComponent<Animation>().Play("FadeAnim");
        StartCoroutine(LoadNextScene());
    }

    private IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame() => Application.Quit();

    public void DisplayCredits()
    {
        creditsMenu.SetActive(true);
        settingsMenu.SetActive(false);
        parentMainMenu.SetActive(false);
    }

    public void DisplayMainMenu()
    {
        creditsMenu.SetActive(false);
        settingsMenu.SetActive(false);
        parentMainMenu.SetActive(true);
    }

    public void DisplaySettings()
    {
        creditsMenu.SetActive(false);
        settingsMenu.SetActive(true);
        parentMainMenu.SetActive(false);
    }
}
