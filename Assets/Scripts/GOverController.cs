using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GOverController : MonoBehaviour
{
    public AudioSource buttonClickSound, endOfGame;  // Reference to the AudioSource component
    public GameObject gameOverUI;  // Game Over UI Panel
    public Button restartButton;   // Restart Button
    public Button quitButton;      // Quit Button

    private bool isGameOver = false;


    void Awake()
    {
        isGameOver = true;
        PlaySound(endOfGame);
        Time.timeScale = 0f;         // Pause the game
    }

    // This function is called when the button is clicked
    public void ReStartGame()
    {
        // Play the click sound
        PlaySound(buttonClickSound);
        isGameOver = false;
        Debug.Log("Restarting game.");
        Time.timeScale = 1f;    // Unpause the game
        // Load the game main scene
        SceneManager.LoadScene("RollBallTrack");
    }

    // This function is called when the exit button is clicked
    public void QuitGame()
    {
        PlaySound(buttonClickSound); // Play the click sound
        Debug.Log("Quitting game...");
        Time.timeScale = 0f;
        Application.Quit();
     
    }

    // Function to play the sound
    private void PlaySound(AudioSource sound)
    {
        if (sound != null)
        {
            sound.Play();  // Play the sound effect
        }
    }

    // Start is called before the first frame update
      void Start()
    {
 //        SceneManager.LoadScene("RollBallMenu");  
    }

    // Update is called once per frame
    //  void Update()
    //  {
    //      
    //  }
}
