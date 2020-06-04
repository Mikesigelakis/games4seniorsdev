using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject[] playerPanels;

    [HideInInspector]
    public bool gameIsOver = false;
    [HideInInspector]
    public int ammoCount = 0;


    public void AddPlayerPanel(int index)       
    {
        if (FindObjectOfType<Spawner>().spawnedObstacles != 0)      
            Destroy(GameObject.FindGameObjectWithTag("PlayerPanel").gameObject, 0.45f);     
        Instantiate(playerPanels[index], transform.position, Quaternion.identity);     
    }
}
