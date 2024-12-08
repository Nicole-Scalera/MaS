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
        AudioManager.Instance.PlayUI("ButtonClick1");   // Trigger Sound
        tutorialUI.SetActive(true);                     // Trigger Animation
        Debug.Log("Tutorial Opened");                   // Debugging
        
    }

    public void OnCreditsButton()
    {
        AudioManager.Instance.PlayUI("ButtonClick1");   // Trigger Sound
        creditsUI.SetActive(true);                      // Trigger Animation
        Debug.Log("Credits Opened");                    // Debugging
    }

    // Called when exiting a pop-up menu
    public void OnExitButton()
    {
        // Exit a given pop-up message
        tutorialUI.SetActive(false);    // Exit tutorial
        creditsUI.SetActive(false);     // Exit credits
        Debug.Log("Exit UI");           // Debugging
    }

    // Called when the "Quit" button is clicked
    public void OnQuitButton()
    {
        AudioManager.Instance.PlayUI("ButtonClick1");   // Trigger Sound
        Debug.Log("Quitting game...");                  // Debugging
        Application.Quit();                             // Quit the application
    }


}