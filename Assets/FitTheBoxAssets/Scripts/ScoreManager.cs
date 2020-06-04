using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour {

    public TextMeshProUGUI scoreText;
    public Animation textAnim;

    [HideInInspector]
    public int score = 0;

    public void IncrementScore()
    {
        if (Spawner.kindOfGame !="levelGame"){
        if (FindObjectOfType<Player>().gameIsOver == false)      
            scoreText.text = (++score).ToString();      
        textAnim.Play();      
        }
    }
}
