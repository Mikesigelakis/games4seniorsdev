using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class soundManager : MonoBehaviour {
    public AudioSource playMusic;
    static AudioSource getcoin;
    static AudioSource getime;
    static AudioSource hitwall;
    public GameObject muteImage;

    public static bool mute = true;

    private AudioSource[] audioSourcesComponents;

    void Start () {
        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;

        if (sceneName == "scene") {
            audioSourcesComponents = GetComponents<AudioSource> ();
            getcoin = audioSourcesComponents[0];
            getime = audioSourcesComponents[1];
            hitwall = audioSourcesComponents[2];
        }
    }

    public static void coinCollisionSound () {
        if (mute == false) getcoin.Play ();
    }

    public static void timeCollisionSound () {
        if (mute == false) getime.Play ();
    }

    public static void wallCollisionSound () {
        if (mute == false) hitwall.Play ();
    }

    public void muteHandler () {
       
        if (mute==false) {
            muteImage.SetActive (false);
            playMusic.mute  = false;
            mute = true;
            return;
        }
        if (mute== true) {
            
            muteImage.SetActive (true);
            playMusic.mute = true;
            mute = false;
            
           
        }
         
    }

}