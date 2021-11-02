using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Collector : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    void IncreaseScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Bomb")
        {
            IncreaseScore();
            target.gameObject.SetActive(false);
        }
    }
}
