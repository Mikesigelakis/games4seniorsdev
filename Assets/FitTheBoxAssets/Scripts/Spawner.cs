using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] obstacles;
    public bool randomObstacles = false;
    public int fistTypeAfter = 7, secondTypeAfter = 20, thirdTypeAfter = 35;

    [HideInInspector]
    public int spawnedObstacles = 0;

    private int obstacleType = 0;
    public static string kindOfGame;
    public static int level;
    void Start () {
        Spawn ();
    }

    public void Spawn () {

        if (kindOfGame == "AdventureGame")
            IncreasingSpawn ();
        else if (kindOfGame == "levelGame") {
            SpecificSpawn (level);
        }

        FindObjectOfType<Player> ().AddPlayerPanel (obstacleType);
        spawnedObstacles++;
    }

    public void SpecificSpawn (int level) {
        switch (level) {
            case 1:
                Instantiate (obstacles[0], transform.position, Quaternion.identity);
                obstacleType = 0;
                break;
            case 2:
                Instantiate (obstacles[1], transform.position, Quaternion.identity);
                obstacleType = 1;
                break;
            case 3:
                Instantiate (obstacles[2], transform.position, Quaternion.identity);
                obstacleType = 2;
                break;
            case 4:
                Instantiate (obstacles[3], transform.position, Quaternion.identity);
                obstacleType = 3;
                break;
            default:
                int randomPos = Random.Range (0, obstacles.Length);
                obstacleType = randomPos;
                Instantiate (obstacles[randomPos], transform.position, Quaternion.identity);
                break;
        }
    }

    public void IncreasingSpawn () {
        if (spawnedObstacles < fistTypeAfter) {
            Instantiate (obstacles[0], transform.position, Quaternion.identity);
            obstacleType = 0;
        } else if ((spawnedObstacles >= fistTypeAfter) && (spawnedObstacles < secondTypeAfter)) {
            Instantiate (obstacles[1], transform.position, Quaternion.identity);
            obstacleType = 1;
        } else if ((spawnedObstacles >= secondTypeAfter) && (spawnedObstacles < thirdTypeAfter)) {
            Instantiate (obstacles[2], transform.position, Quaternion.identity);
            obstacleType = 2;
        } else {
            Instantiate (obstacles[3], transform.position, Quaternion.identity);
            obstacleType = 3;
        }
    }

}