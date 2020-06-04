using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SolutionCube : MonoBehaviour
{
    public static string kindOfGame;





    private void OnCollisionEnter(UnityEngine.Collision other)
    {

        GameObject.Find("congratulationsText").GetComponent<Text>().text = "Congratulations!";
 
      

    }

  
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

}

