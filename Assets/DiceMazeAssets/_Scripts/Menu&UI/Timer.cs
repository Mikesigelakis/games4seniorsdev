using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float currentTime;
    public static float startinTime;
    public static int levelGame;
    [SerializeField]
    public Text countDownText;
    public GameObject outOFtimePanel;


    void Start()
    {
        switch (levelGame)
        {
            case 4:
                startinTime = 10f;
                break;
            case 5:
                startinTime = 20f;
                break;
            case 6:
                startinTime = 30f;
                break;
            case 7:
                startinTime = 50f;
                break;
            case 8:
                startinTime = 60f;
                break;
            case 9:
                startinTime = 70f;
                break;
            case 10:
                startinTime = 90f;
                break;
            case 11:
                startinTime = 120f;
                break;
            case 12:
                startinTime = 140f;
                break;
            case 13:
                startinTime = 160f;
                break;
            default:
                if (MazeController.mazeSizeX < 6)
                {
                    startinTime = MazeController.mazeSizeX * 7;
                    break;
                }
                startinTime = MazeController.mazeSizeX * 12;
                break;

        }

        currentTime = startinTime;
    }

    void Update()
    {
        if (DiceMazeGameManager.pauseGame == true) return;
        currentTime -= 1 * Time.deltaTime;
        if (currentTime <= 4.49f)
        {
            countDownText.color = Color.red;
        }
        countDownText.text = currentTime.ToString("0");
        if (currentTime <= 0)
        {
            currentTime = 0;
            outOFtimePanel.SetActive(true);
        }

    }


    public void HourGlassCall()
    {
        currentTime += 15 * Time.deltaTime;
        countDownText.text = currentTime.ToString("0");
    }
}