using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/* This class will store the following:
 *    1. The name of a clue
 *    2. The description to be displayed via the Inventory
 *
 * It is similar to the Clue class, but only passes in the parameters
 * that will be visible to the user in the Inventory UI.
 *
 * All clues are initialized in the clueCatalog at the start of the game (see
 * InventoryManager), but clues are appended to the actual inventoryContents
 * when made visible in the GameScript.yarn.  */

[System.Serializable]
public class Item
{

    public string ItemName { get;  set; } // Name of the clue
    public string ItemDescription { get; set; } // Description displayed in UI

    // Pass in these two parameters
    public Item(string name, string description)
    {
      ItemName = name;
      ItemDescription = description;

    }

}