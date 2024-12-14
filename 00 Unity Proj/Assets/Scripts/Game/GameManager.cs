using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    // Connect the DialogueRunner to the GameManager
    public DialogueRunner dialogueRunner;

    // Connect the InventoryManager to the GameManager
    public InventoryManager inventoryManager;

    // ================================================
    // ================================================
    // ================================================


    // Start is called before the first frame update
    void Start()
    {


    }

    void Update()
    {

    }

    // Create YarnSpinner Command to Create a Clue
    // (see DeclareClue in InventoryManager | See Clue.cs)
    [YarnCommand("DeclareClue")]
    public void DeclareClue(int clueID, string clueName, string clueDescription)
    {
        // Check that the InventoryManager is present
        if (inventoryManager != null)
        {
            inventoryManager.DeclareClue(clueID, clueName, clueDescription);
        }
        else
        {
            // In case the InventoryManger is not there
            Debug.LogWarning("InventoryManager not connected to GameManager.");
        }
    }


    // Create YarnSpinner Command to make a Clue visible or invisible
    // (see DeclareClue in InventoryManager)
    [YarnCommand("ClueVisibility")]
    public void ClueVisibility(int clueID, bool clueVisibility)
    {
        // Check that the InventoryManager is present
        if (inventoryManager != null)
        {
            inventoryManager.ClueVisibility(clueID, clueVisibility);
        }
        else
        {
            // In case the InventoryManger is not there
            Debug.LogWarning("InventoryManager not connected to GameManager.");
        }
    }




}