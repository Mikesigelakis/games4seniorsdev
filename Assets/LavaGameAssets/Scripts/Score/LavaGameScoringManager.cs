using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LavaGameScoringManager : MonoBehaviour {

    public static int score = 0;
    public Text blockScoreLabel;
    public AudioSource audioSource;
    public GameObject losePanel;
    public GameObject gamePanel;
     

    private static int oldHighScore;

    private void Start () {
        score = 0;
        oldHighScore = +PlayerPrefs.GetInt ("Highscore");
      
    }

    void gameOver () {
        losePanel.SetActive (true);
        gamePanel.SetActive (false);
        score = 0;
        blockScoreLabel.text = "Blocks " + score;
        LavaGameManager.pause = true;
    }

    void OnCollisionEnter (UnityEngine.Collision collision) {
        if (gameObject.name == collision.gameObject.tag) {
            score += 1;
            audioSource.GetComponent<SoundManager> ().winPointSound ();
            if (oldHighScore < score && LavaGameSpawner.kindofGame != "levelGame") {
                PlayerPrefs.SetInt ("Highscore", score);
            }
        } else {
            score -= 1;
            audioSource.GetComponent<SoundManager> ().losePointSound ();
        }
        Destroy (collision.gameObject);

        blockScoreLabel.text = "Blocks " + score;
        if (LavaGameSpawner.kindofGame != "levelGame")
            if (score == -1) gameOver ();
    }

}