using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    private int score;
    public TextMeshProUGUI livesText;
    private int lives;

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
}
