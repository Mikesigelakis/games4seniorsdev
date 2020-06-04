using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dont : MonoBehaviour
{
    public AudioSource audioData;
    public static bool play = true;
 

    void Start()
    {
        audioData.Play();
    }

    void Update()
    {
        if (play == false)
        {
            audioData.Pause();
        }
    }
}
