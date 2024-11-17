using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject tutorialUI;
    public GameObject creditsUI;

    public Animator animator;

    void Start()
    {
        tutorialUI.SetActive(false);
        creditsUI.SetActive(false);
    }

    // Make the SceneManager load a scene with an index of 1; Gameplay
    // Called when the "Play" button is clicked
    public void OnPlayButton()
    {
        Debug.Log("Playing game...");
        SceneManager.LoadScene(1);
    }

    // Called when the "Tutorial" button is clicked
    public void OnTutorialButton()
    {
        Debug.Log("Tutorial");
        tutorialUI.SetActive(true);
    }

    public void OnCreditsButton()
    {
        Debug.Log("Credits");
        creditsUI.SetActive(true);
    }

    // Called when the "Quit" button is clicked
    public void OnQuitButton()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }

    public void OnExitButton()
    {
        Debug.Log("Exit UI");
        tutorialUI.SetActive(false);
        creditsUI.SetActive(false);
    }
}