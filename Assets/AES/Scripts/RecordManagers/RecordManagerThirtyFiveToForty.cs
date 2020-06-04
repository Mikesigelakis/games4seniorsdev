using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordManagerThirtyFiveToForty : MonoBehaviour
{
    // Start is called before the first frame update
    public Text R36,R37,R38,R39,R40;

    void Start()
    {
        R36.text = "Level 36 - Record : " + PlayerPrefs.GetInt("LevelCF") + "sec";
        R37.text = "Level 37 - Record : " + PlayerPrefs.GetInt("LevelCG") + "sec";
        R38.text = "Level 38 - Record : " + PlayerPrefs.GetInt("LevelCH") + "sec";
        R39.text = "Level 39 - Record : " + PlayerPrefs.GetInt("LevelCI") + "sec";
        R40.text = "Level 40 - Record : " + PlayerPrefs.GetInt("LevelCJ") + "sec";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
