using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LavaGameManager : MonoBehaviour {

    public static string gameMode;
    public GameObject menuPanel;
    public GameObject gamePanel;
    public GameObject homePanel;
    public GameObject levelPanel;
    public GameObject homeMenu;
    public Text Starttxt;

    public Button startButton;

    public Button pauseButton;
    public GameObject spawner;
    public Button playButton;
    public static bool pause;

    public Button continueButton;
    public Button exitButton;
    public Button exitButton2;
    public Button levelButton;
    public Button homeMenuButton;
    public Button restartButton;
    public Button exitButton3;

    public GameObject losePanel;

    // Start is called before the first frame update
    void Start () {

        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        Debug.Log (sceneName);

        switch (sceneName) {
            case "menuSceneLavaGame":
                playButton.onClick.AddListener (() => StartCoroutine (playButtonListener ()));
                levelButton.onClick.AddListener (() => levelButtonListener ());
                homeMenuButton.onClick.AddListener (() => homeMenuButtonListener ());

                break;
            case "gameSceneLavaGame":
                pause = false;
                pauseButton.onClick.AddListener (() => pauseButtonListener ());
                continueButton.onClick.AddListener (() => continueButtonListener ());
                exitButton.onClick.AddListener (() => exitButtonListener ());
                exitButton2.onClick.AddListener (() => exitButtonListener ());
                exitButton3.onClick.AddListener (() => exitButtonListener ());
                restartButton.onClick.AddListener (() => restartGameButton ());
                stateGame ("PlayGame");
                setPanel ("PlayGame");
                break;
            default:
                break;
        }
    }

    #region Listeners
    IEnumerator playButtonListener () {
        yield return new WaitForSeconds (1.20f);
        pause = false;
        LavaGameSpawner.kindofGame = "NormalGame";
        SceneManager.LoadScene ("gameSceneLavaGame");

    }

    private void pauseButtonListener () {
        pause = true;
        setPanel ("PauseGame");

    }

    private void continueButtonListener () {
        pause = false;
        setPanel ("PlayGame");
    }
    public void returnToMainMenu () {
        SceneManager.LoadScene ("MainScene");

    }

    private void exitButtonListener () {
        SoundManager.isMuted = false;
        SceneManager.LoadScene ("menuSceneLavaGame");
    }
    private void levelButtonListener () {
        homeMenu.SetActive (false);
        homePanel.SetActive (false);
        levelPanel.SetActive (true);
    }
    private void homeMenuButtonListener () {
        homeMenu.SetActive (true);
        homePanel.SetActive (true);
        levelPanel.SetActive (false);
    }

    #endregion

    void stateGame (string gameType) {
        switch (gameType) {
            case "PlayGame":

                pause = false;

                break;
            case "StartGameAgain":
                pause = false;
                break;
        }

    }

    private void setPanel (string gameMode)

    {
        switch (gameMode) {
            case "PlayGame":

                gamePanel.SetActive (true);
                menuPanel.SetActive (false);
                break;
            default:
                gamePanel.SetActive (false);
                menuPanel.SetActive (true);
                break;
        }
    }

    public void ChangeScene (int level) {

        LavaGameSpawner.kindofGame = "levelGame";
        pause = false;

        switch (level) {
            case 1:
                LavaGameSpawner.spawnWait = 2.5f;
                Movement.movementSpeed = 1.5f;
                break;
            case 2:
                LavaGameSpawner.spawnWait = 2.5f;
                Movement.movementSpeed = 2.5f;
                break;
            case 3:
                LavaGameSpawner.spawnWait = 2.0f;
                Movement.movementSpeed = 3.2f;
                break;
            case 4:
                LavaGameSpawner.spawnWait = 2.0f;
                Movement.movementSpeed = 3.7f;
                break;
            case 5:
                LavaGameSpawner.spawnWait = 1.8f;
                Movement.movementSpeed = 3.6f;
                break;
            case 6:
                LavaGameSpawner.spawnWait = 1.5f;
                Movement.movementSpeed = 4.3f;
                break;
            case 7:
                LavaGameSpawner.spawnWait = 1.5f;
                Movement.movementSpeed = 4.8f;
                break;
            case 8:
                LavaGameSpawner.spawnWait = 1.3f;
                Movement.movementSpeed = 4.0f;
                break;
            case 9:
                LavaGameSpawner.spawnWait = 1.0f;
                Movement.movementSpeed = 4.5f;
                break;

            default:

                break;

        }
        SceneManager.LoadScene ("gameSceneLavaGame");
    }

    public void restartGameButton () {
        losePanel.SetActive (false);
        gamePanel.SetActive (true);
        LavaGameScoringManager.score = 0;
        LavaGameManager.pause = false;
        GameObject[] redCubes = GameObject.FindGameObjectsWithTag ("redCube");
        GameObject[] blueCubes = GameObject.FindGameObjectsWithTag ("blueCube");
        foreach (GameObject redCube in redCubes)
            GameObject.Destroy (redCube);
        foreach (GameObject blueCube in blueCubes)
            GameObject.Destroy (blueCube);
        LavaGameSpawner.time = 0;
        TimeScript.currentTime = 0;

    }

}