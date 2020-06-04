using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordManagerFortyToFortyFive : MonoBehaviour
{
    // Start is called before the first frame update
    public Text R41,R42,R43,R44,R45;

    void Start()
    {
        R41.text = "Level 41 - Record : " + PlayerPrefs.GetInt("LevelCK") + "sec";
        R42.text = "Level 42 - Record : " + PlayerPrefs.GetInt("LevelCL") + "sec";
        R43.text = "Level 43 - Record : " + PlayerPrefs.GetInt("LevelCM") + "sec";
        R44.text = "Level 44 - Record : " + PlayerPrefs.GetInt("LevelCN") + "sec";
        R45.text = "Level 45 - Record : " + PlayerPrefs.GetInt("LevelCO") + "sec";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
