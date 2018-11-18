using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("Zombie Shooter Level 1");
    }
    public void EndGame()
    {
        SceneManager.LoadScene("Game Over");
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void QuitGame() // Quits the application when button is pressed.
    {
        Application.Quit();
    }
    public void StartGameInstructions()
    {
        SceneManager.LoadScene("Game Instructions");
    }
}
