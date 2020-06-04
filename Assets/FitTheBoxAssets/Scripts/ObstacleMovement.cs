using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

    public float movementSpeed;

    private Vector3 nextPos;
    private bool spawned = false, speededUp = false;
    private Animation camAnim;

	void Start () {
       
    }
	 
	void Update () {
        if((FindObjectOfType<Player>().ammoCount < 1) && (!speededUp))      
        {
            speededUp = true;
            movementSpeed = 50f;       
        }
        if (!FindObjectOfType<Player>().gameIsOver)    
        {
 
            nextPos = transform.position;
            nextPos.z -= movementSpeed * Time.deltaTime;
            transform.position = nextPos;
        }   
        if ((transform.position.z <= -0.5f) && (!spawned))      
        {
            spawned = true;
            FindObjectOfType<Spawner>().Spawn();
            FindObjectOfType<ScoreManager>().IncrementScore();
            FindObjectOfType<AudioManager>().ScoreSound();
   
        }
	}
}
