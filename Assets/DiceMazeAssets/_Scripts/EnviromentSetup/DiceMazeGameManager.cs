using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DiceMazeGameManager : MonoBehaviour {

    public GameObject playerInterfacePanel;
    public GameObject mainMenuPanel;
    public GameObject levelMenuPanel;
    public GameObject gameMenuPanel;
    public GameObject outOFtimePanel;
    public static bool pauseGame = false;

    public void ChangeScene (int sceneToChange) {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        DiceMazeGameManager.pauseGame = false;
        switch (buttonName) {
            case "Button1":
                startPlay (4, "LevelGame");
                break;
            case "Button2":
                startPlay (5, "LevelGame");
                break;
            case "Button3":
                startPlay (6, "LevelGame");
                break;
            case "Button4":
                startPlay (7, "LevelGame");
                break;
            case "Button5":
                startPlay (8, "LevelGame");
                break;
            case "Button6":
                startPlay (9, "LevelGame");
                break;
            case "Button7":
                startPlay (10, "LevelGame");
                break;
            case "Button8":
                startPlay (11, "LevelGame");
                break;
            case "Button9":
                startPlay (12, "LevelGame");
                break;
            case "Button10":
                startPlay (13, "LevelGame");
                break;
            default:
                dont.play = true;
                CameraController.levelGame = 1;
                Timer.levelGame = 0;
                MazeController.mazeSizeX = 3;
                MazeController.mazeSizeZ = 3;
                ScrollAndPinch.level = 3;
                SolutionCube.kindOfGame = "AdventureGame";
                Coin.coinNumber = 0;

                Scene currentScene = SceneManager.GetActiveScene ();
                string sceneName = currentScene.name;
                //    if (sceneName != "sceneMainMenu") { outOFtimePanel.SetActive (false); }

                SceneManager.LoadScene ("diceMazePlayScene");
                break;

        }

    }

    public void startPlay (int level, string kindOfGame) {
        pauseGame = false;
        Timer.levelGame = level;
        CameraController.levelGame = level;
        MazeController.mazeSizeX = level;
        MazeController.mazeSizeZ = level;
        SolutionCube.kindOfGame = kindOfGame;
        ScrollAndPinch.level = level;
        Coin.coinNumber = 0;
        SceneManager.LoadScene ("diceMazePlayScene");

    }

    #region  ButtonListeners

    public void ChooseLevelButton () {
        DiceMazeGameManager.pauseGame = false;
        mainMenuPanel.SetActive (false);
        levelMenuPanel.SetActive (true);
    }
    public void ChooseRulesButton () {

        mainMenuPanel.SetActive (false);
    }
    public void chooseMenuButton () {

        levelMenuPanel.SetActive (false);
        mainMenuPanel.SetActive (true);

    }
    public void chooseHighScoreButton () {
        mainMenuPanel.SetActive (false);
    }
    public void ChooseExitButton () {
        SceneManager.LoadScene ("MainScene");
    }
    public void pauseGameButton () {
        pauseGame = true;
        playerInterfacePanel.SetActive (false);
        gameMenuPanel.SetActive (true);
    }
    public void continueGameButton () {
        playerInterfacePanel.SetActive (true);
        gameMenuPanel.SetActive (false);
        pauseGame = false;
    }
    public void exitGameButton () {
        outOFtimePanel.SetActive (false);
        SceneManager.LoadScene ("diceMazeMenuScene");
    }
}

#endregion