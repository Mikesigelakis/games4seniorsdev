using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HourGlass : MonoBehaviour
{
    Text countDownText;


    void Start()
    {
        countDownText = GameObject.Find("CountDownText").GetComponentInChildren<Text>();
    }

    private void OnCollisionEnter(UnityEngine.Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Timer.currentTime = int.Parse(countDownText.text) + 15;
            soundManager.timeCollisionSound();
            Destroy(gameObject);

        }
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);
    }
}
