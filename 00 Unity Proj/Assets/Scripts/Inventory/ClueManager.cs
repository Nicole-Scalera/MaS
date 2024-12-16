using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class ClueManager : MonoBehaviour
{

    // Create a reference to the storage variable,
    // just like GameManager.cs
    public VariableStorageBehaviour storage;

/* This class will store the following:
 *    1. The name of a clue
 *    2. The description to be displayed via the Inventory
 *    3. Whether or not a clue is visible (i.e. has been discovered) */

    [System.Serializable] // Makes it editable in the Unity Inspector
    public class Clue
    {
        public string clueName; // Name of clue
        public string clueDesc; // Description to be displayed in the Inventory
        public bool clueActive; // Toggle visibility of clue

        // Constructor to put together a clue
        public Clue(string name, string desc, bool active)
        {
            clueName = name;
            clueDesc = desc;
            clueActive = active;
        }

        // If a clue has been created, log this message
        public override string ToString()
        {
            return $"Clue Name: {clueName}, Description: {clueDesc}, Active: {clueActive}";
        }
    }

    // Create a catalog array from the Clue class above
    public Clue[] clueCatalog = new Clue[7];

    void Awake()
    {
        // Check that the storage is connected to the DialogueSystem
        if (storage == null)
        {
            Debug.LogError("VariableStorageBehaviour is not assigned in GameManager!");
        }
    }

    void Start()
    {

        // Populate the clueCatalog array with the variables in GameScript.yarn
        for (int i = 0; i < clueCatalog.Length; i++)
        {
            string clueName;
            string clueDesc;
            bool clueActive;

            // Get the values out of YarnSpinner
            storage.TryGetValue($"$clue{i}Name", out clueName);
            storage.TryGetValue($"$clue{i}Desc", out clueDesc);
            storage.TryGetValue($"$clue{i}Active", out clueActive);

            // Add a new clue to the array
            clueCatalog[i] = new Clue(clueName, clueDesc, clueActive);
        }

        // For each clue created, log the debugging message
        foreach (Clue clue in clueCatalog)
        {
            Debug.Log(clue.ToString());
        }
    }
}
