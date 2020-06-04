using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gethighscore : MonoBehaviour {
    public Text highscore;
    // Start is called before the first frame update
    void Start () {
         highscore.text = "Highscore: " + PlayerPrefs.GetInt ("Highscore").ToString ();
            if (LavaGameSpawner.kindofGame == "levelGame"){
                highscore.text = "";
         }
    }

    // Update is called once per frame
    void Update () {
       
    }
}