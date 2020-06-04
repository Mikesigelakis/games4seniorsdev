using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordManagerTwentyToTwentyFive : MonoBehaviour
{
    // Start is called before the first frame update
    public Text R21,R22,R23,R24,R25;

    void Start()
    {
        R21.text = "Level 21 - Record : " + PlayerPrefs.GetInt("LevelBF") + "sec";
        R22.text = "Level 22 - Record : " + PlayerPrefs.GetInt("LevelBG") + "sec";
        R23.text = "Level 23 - Record : " + PlayerPrefs.GetInt("LevelBH") + "sec";
        R24.text = "Level 24 - Record : " + PlayerPrefs.GetInt("LevelBI") + "sec";
        R25.text = "Level 25 - Record : " + PlayerPrefs.GetInt("LevelBJ") + "sec";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
