using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // Required for scene management

public class CabinManager : MonoBehaviour
{
    public GameObject hauntedMessage;

    void Start()
    {
        // Show the haunted message after a short delay
        Invoke("ShowHauntedMessage", 2f); // 2-second delay before showing the message
    }

    void ShowHauntedMessage()
    {
        hauntedMessage.SetActive(true); // Enable the haunted message
    }

    // This method will be called when you press the exit button
    public void ExitToMenu()
    {
        // Replace "MenuScene" with the exact name of your menu scene
        SceneManager.LoadScene("MainMenu");
    }
}
