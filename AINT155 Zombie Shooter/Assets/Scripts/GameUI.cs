using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GameUI : MonoBehaviour {

    public Slider healthBar;
    public Text scoreText, HealthText, GameOverScoreText;

    public int playerScore = 0;

    private void OnEnable()
    {
        Player.OnUpdateHealth += UpdateHealthBar;
        AddScore.OnSendScore += UpdateScore;
    }

    private void OnDisable()
    {
        Player.OnUpdateHealth -= UpdateHealthBar;
        AddScore.OnSendScore -= UpdateScore;
        PlayerPrefs.SetInt("Score", playerScore);
    }

    private void UpdateHealthBar(int health)
    {
        healthBar.value = health;
        HealthText.text = "HP: " + health.ToString() + "/100";
    }
    private void UpdateScore (int theScore)
    {
        playerScore += theScore;
        GameScore.Score = playerScore;
        print(GameScore.Score);

        scoreText.text = "CURRENT SCORE: " + playerScore.ToString();
 
    }
    private void UpdateHighScore (int theScore)
    {
    }
    // Use this for initialization
    void Start () {
        playerScore = GameScore.Score;
        if (scoreText != null)
        {
            scoreText.text = "CURRENT SCORE: " + playerScore.ToString();
        }
        if (GameOverScoreText != null)
        {
            GameOverScoreText.text = "YOUR FINAL SCORE: " + playerScore.ToString();
            GameScore.Score = 0;//Reset the player's score for when/if they play again.
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
