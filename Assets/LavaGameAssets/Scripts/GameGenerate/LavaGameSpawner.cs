using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LavaGameSpawner : MonoBehaviour {
    public GameObject[] spawns;
    public Vector3 spawnValues;
    public static float spawnWait = 1;
    int randspawn;
    GameObject[] redclones;
    GameObject[] blueclones;
    public GameObject target;

    public static int time = 0;
    public static string kindofGame = "";
    public bool startSpawnAgain = true;

    void Start () {
        Application.targetFrameRate = 60;
        redclones = GameObject.FindGameObjectsWithTag ("redCube");
        blueclones = GameObject.FindGameObjectsWithTag ("blueCube");

    }

    //Update is called once per frame
    void Update () {

        time = (int) (Mathf.Round (TimeScript.currentTime));

        if (kindofGame == "NormalGame") {
            if (time == 0) setLevel ();
            if (time == 10) setLevel ();
            if (time == 20) setLevel ();
            if (time == 30) setLevel ();
            if (time == 40) setLevel ();
            if (time == 50) setLevel ();
            if (time == 60) setLevel ();
            if (time == 70) setLevel ();
            if (time == 80) setLevel ();
            if (time == 90) setLevel ();
        }

        if (startSpawnAgain == true && LavaGameManager.pause == false ) {
             StartCoroutine (waitSpawner ());
            startSpawnAgain = false;
        }

    }

    public static void setLevel () {
        switch (time) {
            case 0:
                spawnWait = 2.5f;
                Movement.movementSpeed = 1.5f;
                break;
            case 10:
                spawnWait = 2.5f;
                Movement.movementSpeed = 2.5f;
                break;
            case 20:
                spawnWait = 2.0f;
                Movement.movementSpeed = 3.2f;
                break;
            case 30:
                spawnWait = 2.0f;
                Movement.movementSpeed = 3.7f;
                break;
            case 40:
                spawnWait = 1.8f;
                Movement.movementSpeed = 3.6f;
                break;
            case 50:
                spawnWait = 1.5f;
                Movement.movementSpeed = 4.3f;
                break;
            case 60:
                spawnWait = 1.5f;
                Movement.movementSpeed = 4.8f;
                break;
            case 70:
                spawnWait = 1.3f;
                Movement.movementSpeed = 4.0f;
                break;
            case 80:
                spawnWait = 1.0f;
                Movement.movementSpeed = 4.5f;
                break;
            case 90:
                spawnWait = 1.0f;
                Movement.movementSpeed = 4.8f;
                break;
            default:

                break;

        }

    }

    public IEnumerator waitSpawner () {
        while (LavaGameManager.pause == false) {
            randspawn = Random.Range (0, 2);
            Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), 1, Random.Range (-spawnValues.z, spawnValues.z));
            Instantiate (spawns[randspawn], spawnPosition + transform.TransformPoint (0, 0, 0), gameObject.transform.rotation);
            yield return new WaitForSeconds (spawnWait);
        }
        if (LavaGameManager.pause == true) {
            startSpawnAgain = true;
            yield return new WaitForSeconds (0);
        }

    }

}