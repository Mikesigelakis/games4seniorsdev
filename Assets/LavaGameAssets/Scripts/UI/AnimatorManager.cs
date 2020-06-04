using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnimatorManager : MonoBehaviour {

   
    bool waitbefore = false;
    int count;
    public Button playButton;



    void Start () {
        playButton.onClick.AddListener (() => playButtonListener ());


    }

    private void playButtonListener () {
        StartCoroutine (ExampleCoroutine ());
    }

    IEnumerator ExampleCoroutine () {
    
        Animator animator = gameObject.GetComponent<Animator>();
        animator.SetBool ("clicked", true);
        yield return new WaitForSeconds (1);
    }

}