using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class GameManager : MonoBehaviour
{
    // Create an instance of the GameManager so
    // that we can easily access it anywhere
    public static GameManager Instance;

    // Connect the DialogueRunner to the GameManager
    public DialogueRunner dialogueRunner;
    public GameObject dialogueSystem;

    // Connect the InventoryManager to the GameManager
    public InventoryManager inventoryManager;
    public GameObject inventorySystem;

    public ClueManager clueManager;

    // Storage for YarnSpinner
    public VariableStorageBehaviour storage;
    // Note: other scripts are referencing this
    // exact storage variable. The current file,
    // GameManager.cs, is the declaration point.

    string _playerName;
    // public Clue[] clueCatalog2 = new Clue[7];
    // public Clue boltCutters;


    // ================================================
    // ================================================
    // ================================================

    // Start is called before the first frame update
    void Start()
    {
        // Use the storage thing
        storage = FindObjectOfType<VariableStorageBehaviour>();

        //continuously get and set values between Unity and Yarnspinner (This works, but it isn't the cleanest option, I just did it for time sake because it was a quick implementation)
        // storage.SetValue("$playerName", boltCutters);
        // storage.TryGetValue("$optionSelected", out _optionSelected);
        // storage.TryGetValue("$moveOn", out _moveOn);
        // storage.TryGetValue("$expression", out _currentExp);
        // storage.SetValue("$score", myPlayer.score);

    }
    
    // Yarn command to create a clue (called from Yarn Spinner)
    [YarnCommand("SetClueInCatalog")]
    public void SetClueInCatalog(string clueName, string clueDescription)
    {
        // Ensure the clueID is within the bounds of the array
        if (inventoryManager != null)
        {
            inventoryManager.SetClueInCatalog(clueName, clueDescription); // Pass clue data to InventoryManager
            Debug.Log($"Clue created: Name: {clueName}, Description: {clueDescription}");
        }
        else
        {
            Debug.LogWarning("InventoryManager reference is missing.");
        }
    }

    private void Awake()
    {
        // Ensure only one instance of GameManager exists
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


    // private void Awake()
    // {
    //     if (inventoryManager == null)
    //     {
    //         inventoryManager = InventoryManager.Instance;
    //     }
    // }

    // Create YarnSpinner Command to Create a Clue
    // (see DeclareClue in InventoryManager | See Clue.cs)
    // [YarnCommand("DeclareClue")]
    // public void DeclareClue(int clueID, string clueName, string clueDescription)
    // {
    //     Debug.Log($"DeclareClue called on GameObject: {gameObject.name}");
    //     // Check that the InventoryManager is present
    //     if (inventoryManager != null)
    //     {
    //         inventoryManager.DeclareClue(clueID, clueName, clueDescription);
    //     }
    //     else
    //     {
    //         // In case the InventoryManger is not there
    //         Debug.LogWarning("InventoryManager not connected to GameManager.");
    //     }
    // }

    // Create YarnSpinner Command to make a Clue visible or invisible
    // (see DeclareClue in InventoryManager)
    // [YarnCommand("ClueVisibility")]
    // public void ClueVisibility(int clueID, bool clueVisibility)
    // {
    //     // Check that the InventoryManager is present
    //     if (inventoryManager != null)
    //     {
    //         inventoryManager.ClueVisibility(clueID, clueVisibility);
    //     }
    //     else
    //     {
    //         // In case the InventoryManger is not there
    //         Debug.LogWarning("InventoryManager not connected to GameManager.");
    //     }
    // }

}
