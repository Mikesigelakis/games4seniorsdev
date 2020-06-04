using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject startPanel, playPanel, endPanel, muteImage, scoreText, levelPanel;
    public TextMeshProUGUI highScoreText, endScoreText, endHighScoreText;

    void Start () {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        StartPanelActivation ();
        HighScoreCheck ();
        AudioCheck ();
    }

    public void Initialize () {
        FindObjectOfType<Spawner> ().enabled = false;
        scoreText.SetActive (false);
    }

    public void StartPanelActivation () {
        startPanel.SetActive (true);
        endPanel.SetActive (false);
    }

    public void EndPanelActivation () {
        startPanel.SetActive (false);
        endPanel.SetActive (true);
        scoreText.SetActive (false);
        HighScoreCheck ();
    }

    public void SkinsPanelActivation () {
        scoreText.SetActive (true);
        startPanel.SetActive (false);
    }

    public void HighScoreCheck () {
        if (FindObjectOfType<ScoreManager> ().score > PlayerPrefs.GetInt ("HighScore", 0)) {
            PlayerPrefs.SetInt ("HighScore", FindObjectOfType<ScoreManager> ().score);
        }
        highScoreText.text = "BEST " + PlayerPrefs.GetInt ("HighScore", 0).ToString ();
        endHighScoreText.text = "BEST " + PlayerPrefs.GetInt ("HighScore", 0).ToString ();
    }

    public void AudioCheck () {
        if (PlayerPrefs.GetInt ("Audio", 0) == 0) {
            muteImage.SetActive (false);
            FindObjectOfType<AudioManager> ().soundIsOn = true;
            FindObjectOfType<AudioManager> ().PlayBackgroundMusic ();
        } else {
            muteImage.SetActive (true);
            FindObjectOfType<AudioManager> ().soundIsOn = false;
            FindObjectOfType<AudioManager> ().StopBackgroundMusic ();
        }
    }

    public void QuitButton () {
        SceneManager.LoadScene ("MainScene");
    }

    public void StartButton () {
        Spawner.kindOfGame = "AdventureGame";
        FindObjectOfType<Spawner> ().enabled = true;
        scoreText.SetActive (true);
        startPanel.SetActive (false);
    }

    public void LevelButton () {
        startPanel.SetActive (false);
        levelPanel.SetActive (true);
    }

    public void chooseLevelButton (int level) {
        Spawner.level = level;
        Spawner.kindOfGame = "levelGame";
        levelPanel.SetActive (false);
        FindObjectOfType<Spawner> ().enabled = true;

    }

    public void ExitLevelPanel () {
        startPanel.SetActive (true);
        levelPanel.SetActive (false);
    }

    public void RestartButton () {
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
    }

    public void AudioButton () {
        if (PlayerPrefs.GetInt ("Audio", 0) == 0)
            PlayerPrefs.SetInt ("Audio", 1);
        else
            PlayerPrefs.SetInt ("Audio", 0);
        AudioCheck ();
    }
}