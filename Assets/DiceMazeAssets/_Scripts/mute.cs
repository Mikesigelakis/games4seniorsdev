using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mute : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource mutesound;
    public Button mutesnd;
    bool isMute = false;
    void Start()
    {
        Button btn = mutesnd.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (!isMute)
        {
            mutesound.Pause();
            isMute = true;
        }
        else
        {
            mutesound.Play();
            isMute = false;
        }
          
    }
}
