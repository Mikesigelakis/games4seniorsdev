using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordManagerTenToFifteen : MonoBehaviour
{
    // Start is called before the first frame update
    public Text R11,R12,R13,R14,R15;

    void Start()
    {
        R11.text = "Level 11 - Record : " + PlayerPrefs.GetInt("LevelAK") + "sec";
        R12.text = "Level 12 - Record : " + PlayerPrefs.GetInt("LevelAL") + "sec";
        R13.text = "Level 13 - Record : " + PlayerPrefs.GetInt("LevelAM") + "sec";
        R14.text = "Level 14 - Record : " + PlayerPrefs.GetInt("LevelAN") + "sec";
        R15.text = "Level 15 - Record : " + PlayerPrefs.GetInt("LevelAO") + "sec";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
