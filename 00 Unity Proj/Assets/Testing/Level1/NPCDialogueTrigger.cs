using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class NPCDialogueTrigger : MonoBehaviour
{
    public GameObject PressEUI;
    public DialogueRunner dialogueRunner; // Reference to Yarn Spinner's DialogueRunner
    public string dialogueNode; // Reference to Yarn Spinner dialogue node to start

    // Start is called before the first frame update
    void Start()
    {
        PressEUI.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that entered the trigger is player
        if (other.CompareTag("Player"))
        {
            // Activate the UI element
            PressEUI.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Check if the obhect that exited the trigger is player
        if (other.CompareTag("Player"))
        {
            // Deactivate the UI element
            PressEUI.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the UI element is active (i.e., player in range) and "E" key is pressed
        if (PressEUI.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            // Start dialogue/interaction
            PressEUI.SetActive(false);
            StartDialogue();
        }
    }

    private void StartDialogue()
    {
        if (dialogueRunner.IsDialogueRunning)
        {
            // Implement dialogue start code here (WIP)
            Debug.Log("Dialogue has been started.");
            return;
        }
    
        dialogueRunner.StartDialogue(dialogueNode);
        Debug.Log($"Started dialogue: {dialogueNode}"); 
    }
}