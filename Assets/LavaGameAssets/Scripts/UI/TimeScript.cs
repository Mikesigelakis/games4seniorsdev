using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{

    public static float currentTime;
    public static float startinTime;
 
    public Text timerLabel;

    private void Start()
    {

        timerLabel.text = PlayerPrefs.GetInt("Highscore").ToString();
        timerLabel.text = 0.ToString();
        startinTime = 0f;
        currentTime = startinTime;

    }
    void Update()
    {
    
        if (!LavaGameManager.pause)
        {
            timerLabel.enabled = true;
            currentTime += 1 * Time.deltaTime;
            timerLabel.text ="Time " + currentTime.ToString("0");
           
      


        }
    }


}
