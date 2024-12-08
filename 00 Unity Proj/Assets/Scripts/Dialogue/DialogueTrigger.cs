using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject dialogueButton;

    private void Start()
    {
        // Ensure the button is hidden at the start
        dialogueButton.SetActive(false);
    }

    // Detect when the player enters the trigger area (NPC's collision box)
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that entered is tagged as "Player"
        if (other.CompareTag("Player"))
        {
            dialogueButton.SetActive(true);
        }
    }

    // When the player exits the NPC's collision box
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            dialogueButton.SetActive(false);
        }
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
