using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordManagerFiveToTen : MonoBehaviour
{
    // Start is called before the first frame update
    public Text R6,R7,R8,R9,R10;

    void Start()
    {
        R6.text = "Level 6 - Record : " + PlayerPrefs.GetInt("LevelAF") + "sec";
        R7.text = "Level 7 - Record : " + PlayerPrefs.GetInt("LevelAG") + "sec";
        R8.text = "Level 8 - Record : " + PlayerPrefs.GetInt("LevelAH") + "sec";
        R9.text = "Level 9 - Record : " + PlayerPrefs.GetInt("LevelAI") + "sec";
        R10.text = "Level 10 - Record : " + PlayerPrefs.GetInt("LevelAJ") + "sec";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
