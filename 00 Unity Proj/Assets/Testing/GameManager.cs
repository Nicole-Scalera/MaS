using UnityEngine;
using UnityEngine.Playables;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // Singleton instance

    public CutsceneManager cutsceneManager; // Reference to the CutsceneManager
    public bool playIntroCutsceneOnStart = true; // Flag to control cutscene playback

    private void Awake()
    {
        // Ensure only one GameManager exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persist across scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // Automatically play the intro cutscene if the flag is enabled
        if (playIntroCutsceneOnStart && cutsceneManager != null)
        {
            cutsceneManager.PlayCutscene(0); // Play the first cutscene
        }
    }
}
