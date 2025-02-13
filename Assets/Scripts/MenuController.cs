using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;  // Required for Button

public class MenuController : MonoBehaviour
{
    public AudioSource buttonClickSound;  // Reference to the AudioSource component

    // This function is called when the button is clicked
    public void StartGame()
    {
        // Load the game main scene 
        PlaySound(); // Play the click sound
        SceneManager.LoadScene("RollBallTrack");
    }

    // This function is called when the exit button is clicked
    public void QuitGame()
    {
        PlaySound(); // Play the click sound
        Debug.Log("Quitting game...");
        Application.Quit();
    }

    // Function to play the sound
    private void PlaySound()
    {
       if (buttonClickSound != null)
        {
            buttonClickSound.Play();  // Play the sound effect
        }
    }

    // Start is called before the first frame update
    void Start()
    {
 //       SceneManager.LoadScene("RollBallMenu");
   }

    // Update is called once per frame
  //  void Update()
  //  {
  //      
  //  }
}
