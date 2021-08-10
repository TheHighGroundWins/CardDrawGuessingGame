using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    int score;
    [SerializeField]
    TextMeshProUGUI scoreText;

    public void SetScore(int playerScore)
    {
        score = playerScore;
        int finalScore = (52 - score) * 2;
        scoreText.text = "Player Score: "+finalScore;
    }
}
