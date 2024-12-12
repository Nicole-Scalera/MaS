using UnityEngine;
using UnityEngine.UI;
using TMPro;

// RequireComponent ensures the PlayerInventory script will automatically
// be attached to the Player object along with this script.

[RequireComponent(typeof(InventoryManager))]
public class InventoryDisplayManager : MonoBehaviour 
{
	// Reference the "Text-Carrying-Clue" in the UI.
	public TMP_Text inventoryText; // Because it is public, it needs to be
								   // assigned manually in the Inspector.

	//------------------------------
	// Update message on screen to indicate the player has the clue.
	public void OnChangeCarryingClue(bool carryingClue)
	{
		// default message - we're not carrying a star
		string clueMessage = "no star :-(";

		// If we are carrying the clue,
		if(carryingClue)
		{
			// Update the message string
            clueMessage = "Carrying star :-)";
        }

		// Update the Text-Carrying-Clue's contents
		inventoryText.text = clueMessage;
	}
}