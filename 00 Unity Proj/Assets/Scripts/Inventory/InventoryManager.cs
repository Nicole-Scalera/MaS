using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.UI;
using TMPro;
using System;
//using static Sirenix.Utilities.Editor.MultilineWrapLayoutUtility;

public class InventoryManager : MonoBehaviour
{

    // Create an instance of the InventoryManager so
    // that we can easily access it anywhere
    public static InventoryManager Instance;

    // Create an Inventory array to append discovered clues
    public List<string> inventoryContents = new List<string>();

    // Create a catalog array from the Clue class (see Clue.cs)
    public Clue[] clueCatalog = new Clue[7];

    // Initialize the array with placeholder clues
    public InventoryManager()
    {
        for (int i = 0; i < clueCatalog.Length; i++)
        {
            // Create a new clue from the clue class
            clueCatalog[i] = new Clue("", "", false); // Initialize with default values
        }
    }

    /* Initialize a Clue and the following:
     *      1. ID (index # in the clueCatalog)
     *          - So the computer can find the clue
     *      2. Name
     *          - So us humans can find the clue
     *      3. Description
     *          - i.e. what does the player see when clue
     *          [id] is selected in the inventory?          */

    public void DeclareClue(int id, string name, string description)
    {
        if (id >= 0 && id < clueCatalog.Length)
        {
            clueCatalog[id].ClueName = name;
            clueCatalog[id].ClueDescription = description;

            // Add code here to add it to the inventory.

            // If the clue has been created, log this message
            Debug.Log($"CLUE CREATED: Clue Clue Name: {name}, ID: {id}");
        }
        else
        {
            Debug.LogWarning($"Clue at index {id} is either out of bounds or does not exist.");
        }
    }

    /* Find a Clue and update the Visibility value.
     *      1. ID (index # in the clueCatalog)
     *      2. Visibility
     *          - i.e. is the clue present in the inventory?  
     *              - False = Not in Inventory
     *              - True = Inventory contains this clue
     *
     * I made this a separate function from DeclareClue, as
     * the time of activation is different for each clue.          */

    public void ClueVisibility(int id, bool visibility)
    {
        if (id >= 0 && id < clueCatalog.Length) // If the clue id is out of bounds
        {
            // Toggle the visibility of the clue
            clueCatalog[id].ClueVisibility = visibility;

            // If the clue's visibility has been adjusted, log this message
            Debug.Log($"CLUE UPDATED: Clue Name: {name}, ID: {id}, Visible: {visibility}");
        }
        else
        {
            Debug.LogWarning($"Clue at index {id} is either out of bounds or does not exist.");
        }
    }

    /* Check that a clue is in the Inventory.
     *
     *
     *
     *
     */

}


    /* ===== Dialogue Clues =====
	* This is for clues collected through dialogue interactions.
	* The intention is to connect this to the GameScript.yarn.
	*/