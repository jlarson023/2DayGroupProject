using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    private int score;
    public TextMeshProUGUI livesText;
    private int lives;
    public TextMeshProUGUI titleText;

    public Button start;
    public bool gameIsActive = false;
    public bool startCalled = false;

    public Image goodMole;
    public Image badMole;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScore(score);
        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void UpdateLives(int livesToTake)
    {
        lives -= livesToTake;
        livesText.text = "Lives: " + lives;
    }

    public void StartGame()
    {
        Debug.Log("Started Game");
        titleText.gameObject.SetActive(false);
        goodMole.gameObject.SetActive(false);
        badMole.gameObject.SetActive(false);
        start.gameObject.SetActive(false);
        livesText.gameObject.SetActive(true);
        scoreText.gameObject.SetActive(true);
        gameIsActive = true;

    }
}
