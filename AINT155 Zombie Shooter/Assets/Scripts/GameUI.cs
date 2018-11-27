using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GameUI : MonoBehaviour {

    public Slider healthBar;
    public Text scoreText, HealthText;

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
    }

    private void UpdateHealthBar(int health)
    {
        healthBar.value = health;
        HealthText.text = "HP: " + health.ToString() + "/100";
    }
    private void UpdateScore (int theScore)
    {
        playerScore += theScore;
        scoreText.text = "CURRENT SCORE: " + playerScore.ToString();

    }
    private void UpdateHighScore (int theScore)
    {
    }
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
