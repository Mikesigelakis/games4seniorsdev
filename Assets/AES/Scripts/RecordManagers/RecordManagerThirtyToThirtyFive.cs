using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordManagerThirtyToThirtyFive : MonoBehaviour
{
    // Start is called before the first frame update
    public Text R31,R32,R33,R34,R35;

    void Start()
    {
        R31.text = "Level 31 - Record : " + PlayerPrefs.GetInt("LevelCA") + "sec";
        R32.text = "Level 32 - Record : " + PlayerPrefs.GetInt("LevelCB") + "sec";
        R33.text = "Level 33 - Record : " + PlayerPrefs.GetInt("LevelCC") + "sec";
        R34.text = "Level 34 - Record : " + PlayerPrefs.GetInt("LevelCD") + "sec";
        R35.text = "Level 35 - Record : " + PlayerPrefs.GetInt("LevelCE") + "sec";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
