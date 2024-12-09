using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    // Create an instance of the AudioManager so
    // that we can easily access it anywhere
    public static AudioManager Instance;

    // Create an array from the Sound class (see Sound.cs)
    public Sound[] musicSounds, UISounds, SFXSounds;
    public AudioSource musicSource, UISource, SFXSource;
    //                 ^^^ CreateGameObjects for these sources and attach them to
    //                     the AudioManager GameObject. Make sure the AudioSource
    //                     component is attached to each source object.


    // private void Start()
    // {
    //     // Preload and warm up the UI audio source
    //     if (UISource.clip == null && UISounds.Length > 0)
    //     {
    //         UISource.clip = UISounds[0].clip; // Assign any valid clip (or create a silent dummy clip)
    //         UISource.Play();                 // Play briefly to initialize the source
    //         UISource.Stop();                 // Stop immediately
    //     }
    // }


    private void Start()
    {

        // Ensure that there is only one AudioManager present

        // If there is no existing instance of the object
        if (Instance == null)
        {
            // Make the current object the instance
            Instance = this;

            // Prevent destroying the object as you're
            // switching scenes
            DontDestroyOnLoad(gameObject);

        }
        
        // Otherwise, if the AudioManager already exists,
        // destroy the new one to keep one instance
        else
        {
            Destroy(gameObject);
        }

    }

    // ===== MUSIC =====
    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.name == name);

        // Verify that there is a music clip of a specific name
        if (s != null) {

            // If so, play the music clip
            musicSource.clip = s.clip;
            musicSource.Play();
            
        }

        // If not, return this message in the Console
        else
        {
            Debug.Log("Music Sound " + '"' + name + '"' + " Not Found. :(");
        }

    }


    // ===== UI =====
    public void PlayUI(string name)
    {
        Sound s = Array.Find(UISounds, x => x.name == name);

        // Verify that there is a UI clip of a specific name
        if (s != null)
        {

            // If so, play the UI clip
            UISource.PlayOneShot(s.clip);
            
        }

        // If not, return this message in the Console
        else
        {
            Debug.Log("UI Sound " + '"' + name + '"' + " Not Found. :(");
        }

    }


    // ===== SFX =====
    public void PlaySFX(string name)
    {
        Sound s = Array.Find(SFXSounds, x => x.name == name);

        // Verify that there is an SFX clip of a specific name
        if (s != null)
        {

            // If so, play the UI clip
            SFXSource.PlayOneShot(s.clip);
            
        }

        // If not, return this message in the Console
        else
        {
            Debug.Log("UI Sound " + '"' + name + '"' + " Not Found. :(");
        }

    }


}