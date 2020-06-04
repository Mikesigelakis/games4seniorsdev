using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{

    public static int coinNumber;
 
    Text coinText;
    
    void Start()
    {
        coinText = GameObject.Find("CountCoinText").GetComponent<Text>();
            
         coinText.text = coinNumber.ToString();
    }

    private void OnCollisionEnter(UnityEngine.Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            coinNumber = int.Parse(coinText.text) + 1;
            coinText.text = coinNumber.ToString();
            
            Destroy(gameObject);
            soundManager.coinCollisionSound();


        }
    }

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
