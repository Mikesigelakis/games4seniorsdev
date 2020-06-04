using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

    public GameObject destroyedParticle;
  
    void OnMouseDown()      //If the object has been clicked
    {
        if ((FindObjectOfType<Player>().ammoCount > 0) && (!FindObjectOfType<Player>().gameIsOver))     
        {
            FindObjectOfType<AudioManager>().HavocSound();      
            Destroy(Instantiate(destroyedParticle, transform.position, Quaternion.identity), 1f);      
            Destroy(gameObject);         
            FindObjectOfType<Player>().ammoCount--;    
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))        
        {
            //Game over functions
            FindObjectOfType<AudioManager>().DeathSound();
            Destroy(Instantiate(destroyedParticle, transform.position, Quaternion.identity), 1f);
            GetComponent<Animation>().Play("CubeDeathAnim");
            FindObjectOfType<Player>().gameIsOver = true;
            FindObjectOfType<GameManager>().EndPanelActivation();
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animation>().Play("CameraDeathAnim");
        }
    }
}
