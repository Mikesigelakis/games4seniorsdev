using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordManagerFifteenToTwenty : MonoBehaviour
{
    // Start is called before the first frame update
    public Text R16,R17,R18,R19,R20;

    void Start()
    {
        R16.text = "Level 16 - Record : " + PlayerPrefs.GetInt("LevelBA") + "sec";
        R17.text = "Level 17 - Record : " + PlayerPrefs.GetInt("LevelBB") + "sec";
        R18.text = "Level 18 - Record : " + PlayerPrefs.GetInt("LevelBC") + "sec";
        R19.text = "Level 19 - Record : " + PlayerPrefs.GetInt("LevelBD") + "sec";
        R20.text = "Level 20 - Record : " + PlayerPrefs.GetInt("LevelBE") + "sec";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
