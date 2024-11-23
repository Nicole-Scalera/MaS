using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Declare UIs
    public GameObject tutorialUI;
    public GameObject creditsUI;
    
    void Start()
    {
        tutorialUI.SetActive(false);
        creditsUI.SetActive(false);
    }

    // Make the SceneManager load a scene with an index of 1; Gameplay
    // - This is called when the "Play" button is clicked
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
        // Quit the entire application
        Debug.Log("Quitting game...");
        Application.Quit();
    }

    public void OnExitButton()
    {
        // Exit a given pop-up message
        Debug.Log("Exit UI");
        tutorialUI.SetActive(false);    // Exit tutorial
        creditsUI.SetActive(false);     // Exit credits
    }
}