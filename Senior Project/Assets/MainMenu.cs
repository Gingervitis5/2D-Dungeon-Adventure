using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject parentObject;
    public GameObject credits;

    public GameObject Credits { get => credits; set => credits = value; }

    public void PlayGame() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    public void QuitGame() => Application.Quit();

    public void DisplayCredits()
    {
        credits.SetActive(true);
        parentObject.SetActive(false);
    }

}
