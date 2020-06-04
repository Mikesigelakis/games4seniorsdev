using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordManagerTwentyFiveToThirty : MonoBehaviour
{
    // Start is called before the first frame update
    public Text R26,R27,R28,R29,R30;

    void Start()
    {
        R26.text = "Level 26 - Record : " + PlayerPrefs.GetInt("LevelBK") + "sec";
        R27.text = "Level 27 - Record : " + PlayerPrefs.GetInt("LevelBL") + "sec";
        R28.text = "Level 28 - Record : " + PlayerPrefs.GetInt("LevelBM") + "sec";
        R29.text = "Level 29 - Record : " + PlayerPrefs.GetInt("LevelBN") + "sec";
        R30.text = "Level 30 - Record : " + PlayerPrefs.GetInt("LevelBO") + "sec";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
