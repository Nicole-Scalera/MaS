using UnityEngine;
using UnityEngine.Playables;

public class CutsceneManager : MonoBehaviour
{
    // Declare an array of cutscenes
    public PlayableDirector[] cutscenes;
    //                         ^ Append these through the Inspector box
    //                           of the CutsceneManager game object.

    // Keep track of the current cutscene
    private int currentCutscene = 0;
    //          ^ Updates each time a cutscene is initialized using PlayCutscene()

    void Start()
    {
        // Optional: Automatically play the first cutscene if desired
        if (cutscenes.Length > 0 && cutscenes[0] != null)
        {
            PlayCutscene(0);
        }
    }

    public void PlayCutscene(int index)
    {
        if (index >= 0 && index < cutscenes.Length && cutscenes[index])
        {
            currentCutscene = index;

            // If there are any other cutscenes playing
            foreach (var director in cutscenes)
            {
                if (director.state == PlayState.Playing)
                {
                    // Stop those other cutscenes
                    director.Stop();
                }
            }

            // Subscribe to the stopped event
            cutscenes[index].stopped += CutsceneComplete;

            // Play the cutscene
            cutscenes[index].Play();
        }
        else
        {
            // Debugging
            Debug.LogWarning("ERROR: Cutscene is out of range or unassigned.");
        }
    }

    private void CutsceneComplete(PlayableDirector director)
    {
        // Unsubscribe to avoid duplicate events
        director.stopped -= CutsceneComplete;

        // Move to the next cutscene
        int nextCutscene = currentCutscene + 1;
        
        // Ensure the next cutscene isn't outside of the array
        if (nextCutscene < cutscenes.Length)
        {
            PlayCutscene(nextCutscene);
        }
        else
        {
            Debug.Log("All cutscenes finished.");
        }
    }

    public void StopAllCutscenes()
    {
        foreach (var director in cutscenes)
        {
            // If the cutscene is being played
            if (director.state == PlayState.Playing)
            {
                // Stop the playback of all Playables
                director.Stop();
            }
        }
    }
}
