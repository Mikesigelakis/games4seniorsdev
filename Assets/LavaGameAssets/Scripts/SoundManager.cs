using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour {

    public AudioSource audioSource;
    public AudioClip losePoint;
    public AudioClip winPoint;

    public static bool isMuted = false;
    public static AudioSource extraAudioSource;
    public GameObject muteImage;

    // Update is called once per frame

    private void Start () {
        extraAudioSource = gameObject.AddComponent<AudioSource> ();
        Scene scene = SceneManager.GetActiveScene ();
        if (scene.name == "menuSceneLavaGame") { muteImage.SetActive (false); }

    }

    public void audioSourceState () {

        if (isMuted == true) {
            muteImage.SetActive (false);
            audioSource.mute = false;
            isMuted = false;
            return;
        }
        muteImage.SetActive (true);
        audioSource.mute = true;
        isMuted = true;
    }

    public void losePointSound () {
        if (!isMuted) extraAudioSource.PlayOneShot (losePoint);
    }

    public void winPointSound () {
        if (!isMuted) extraAudioSource.PlayOneShot (winPoint);
    }
}