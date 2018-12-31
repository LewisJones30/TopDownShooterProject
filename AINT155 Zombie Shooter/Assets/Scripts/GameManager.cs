using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }
    public void BossInstructions()
    {
        SceneManager.LoadScene("Boss Instructions");
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
    public void Level3Load()
    {
        SceneManager.LoadScene("FinalLevel");
    }
    public void Level2Load()
    {
        SceneManager.LoadScene("Level2");
    }
}
