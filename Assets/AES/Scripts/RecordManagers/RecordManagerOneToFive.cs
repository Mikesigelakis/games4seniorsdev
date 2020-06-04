using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordManagerOneToFive : MonoBehaviour
{
    // Start is called before the first frame update
    public Text R1,R2,R3,R4,R5;

    void Start()
    {
        R1.text = "Level 1 - Record : " + PlayerPrefs.GetInt("LevelAA") + "sec";
        R2.text = "Level 2 - Record : " + PlayerPrefs.GetInt("LevelAB") + "sec";
        R3.text = "Level 3 - Record : " + PlayerPrefs.GetInt("LevelAC") + "sec";
        R4.text = "Level 4 - Record : " + PlayerPrefs.GetInt("LevelAD") + "sec";
        R5.text = "Level 5 - Record : " + PlayerPrefs.GetInt("LevelAE") + "sec";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
