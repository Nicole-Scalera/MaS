using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/* This class will store the following:
 *    1. The name of a clue
 *    2. The description to be displayed via the Inventory
 *    3. Whether or not a clue is visible (i.e. has been discovered) */

[System.Serializable]
public class Clue
{

    public string ClueName { get;  set; } // Name of the clue
    public string ClueDescription { get; set; } // Description displayed in UI
    public bool ClueVisibility { get; set; }  // Visibility state of the clue

    // Pass in these three parameters
    public Clue(string name, string description, bool visibility)
    {
      ClueName = name;
      ClueDescription = description;
      ClueVisibility = visibility;

    }

}


// Side bar: it looks like Visibility is apart of a package called using UnityEngine.UIElements;