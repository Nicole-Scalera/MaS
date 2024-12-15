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


    // ========== Clue Catalog ==========

    // Create a catalog array from the Clue class (see Clue.cs)
    public Clue[] clueCatalog = new Clue[7];

    // Initialize the array with placeholder clues
    public InventoryManager()
    {
        // Create a new clue from the Clue class
        for (int i = 0; i < clueCatalog.Length; i++)
        {
            // Initialize with default values
            clueCatalog[i] = new Clue("", "", false);
            
        }

    }
    
    // ==================================

    // ========== Inventory ==========

    // Create an Inventory array to append discovered clues (see Item.cs)
    public List<Item> inventoryContents = new List<Item>();

    // ===============================

    // ========== Methods ==========

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
            // Delcare a clue by name and description
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

    public void DeclareClueEEE(int id)
    {
        if (id >= 0 && id < clueCatalog.Length)
        {

            // Add code here to add it to the inventory.

            // If the clue has been created, log this message
            Debug.Log($"CLUE CREATED: ID: {id}");
        }
        else
        {
            Debug.LogWarning($"Clue at index {id} is either out of bounds or does not exist.");
        }
    }

    /* Update a Clue's Visibility value:
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

            // // Add the clue to the player's Inventory
            // AddClueToInventory(int id, string name);

            // If the clue's visibility has been adjusted, log this message
            Debug.Log($"CLUE UPDATED: Clue Name: {name}, ID: {id}, Visible: {visibility}");
        }
        else
        {
            Debug.LogWarning($"Clue at index {id} is either out of bounds or does not exist.");
        }
    }

}



////// Comments


        // for (int i = 0; i < clueCatalog.Length; i++)
        // {
        //     // Create a placeholder item from the Item class
        //     clueCatalog[i] = new Clue("", "", false); // Initialize with default values
        // }


    /* Add a Clue to the Inventory:
     *      1. ID (index # in the clueCatalog)
     *      2. Visibility
     *          - i.e. is the clue present in the inventory?  
     *              - False = Not in Inventory
     *              - True = Inventory contains this clue
     *
     * I made this a separate function from DeclareClue, as
     * the time of activation is different for each clue.          */
    // public void AddClueToInventory(int id, string name)
    // {
    //     clueCatalog[id].ClueVisibility = visibility;
    // }

    // =============================

    /* Check that a clue is in the Inventory.
     *
     *
     *
     *
     */



    /* ===== Dialogue Clues =====
	* This is for clues collected through dialogue interactions.
	* The intention is to connect this to the GameScript.yarn.
	*/