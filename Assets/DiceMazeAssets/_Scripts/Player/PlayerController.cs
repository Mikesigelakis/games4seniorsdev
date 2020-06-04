using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{


    private float rollDuration = 0.25f;
    private bool canStartRolling = true;
    public static bool collision = false;
    private Vector3 positionWithoutCollision;
    private Quaternion rotationWithoutCollision;
    Text countDownText;
    private bool pressedTwoButtons = false;
    private IEnumerator coroutine;
    public static int countWallsEnter = 2;

    public Swipe swipeControls;

    Vector3 North;
    Vector3 South;
    Vector3 West;
    Vector3 East;

    private void Start()
    {

        North = new Vector3(0, 0, 1);
        South = new Vector3(0, 0, -1);
        West = new Vector3(-1, 0, 0);
        East = new Vector3(1, 0, 0);

    }

    void OnCollisionEnter(UnityEngine.Collision col)
    {

        if (col.gameObject.CompareTag("Wall"))
        {
            collision = true;
            soundManager.wallCollisionSound();

        }

        if (col.gameObject.CompareTag("Solution"))
        {
            Destroy(col.gameObject);
                   StartCoroutine(GamePauser());

        }

    }

      public IEnumerator GamePauser()
    {
       Timer.currentTime +=1;
        yield return new WaitForSeconds(0.5f);
        if (SolutionCube.kindOfGame == "AdventureGame")
        {
            MazeController.mazeSizeX++;
            MazeController.mazeSizeZ++;
            CameraController.levelGame = MazeController.mazeSizeZ;
            ScrollAndPinch.level++;

            SceneManager.LoadScene(1);
        }
        else if (SolutionCube.kindOfGame == "LevelGame")
        {
            SceneManager.LoadScene(0);
        }
    }

    void shallIStop()
    {
        RaycastHit hit;

        countWallsEnter = 0;

        if (Physics.Raycast(transform.position, (North), out hit, 1))
        {
            countWallsEnter++;
        }

        if (Physics.Raycast(transform.position, (South), out hit, 1))
        {
            countWallsEnter++;
        }

        if (Physics.Raycast(transform.position, (West), out hit, 1))
        {
            countWallsEnter++;
        }

        if (Physics.Raycast(transform.position, (East), out hit, 1))
        {
            countWallsEnter++;
        }

    }

    void Update()
    {
        if (DiceMazeGameManager.pauseGame == true) return;
        countDownText = GameObject.Find("CountDownText").GetComponent<Text>();
        if (countDownText.text == "0")
        {
            canStartRolling = false;
        }

        if (canStartRolling && pressedTwoButtons == false)
        {


            if (swipeControls.SwipeRight)
            {
                pressedTwoButtons = true;
                StartCoroutine(Roll(Vector3.right));

            }
            if (swipeControls.SwipeLeft)
            {
                pressedTwoButtons = true;
                StartCoroutine(Roll(Vector3.left));

            }
            if (swipeControls.SwipeUp)
            {
                pressedTwoButtons = true;
                StartCoroutine(Roll(Vector3.forward));

            }
            if (swipeControls.SwipeDown)
            {
                pressedTwoButtons = true;
                StartCoroutine(Roll(Vector3.back));

            }

        }
    }

    private IEnumerator Roll(Vector3 direction)
    {
        canStartRolling = false;
        while (collision == false && countWallsEnter != 1 && countWallsEnter != 0)
        {
            for (int i = 0; i < 2; i++)
            {
                if (countWallsEnter == 10)
                {
                    transform.position = positionWithoutCollision;
                    transform.rotation = rotationWithoutCollision;
                }
                positionWithoutCollision = transform.position;
                rotationWithoutCollision = transform.rotation;
                float rollDecimal = 0;
                float rollAngle = 90;
                float halfWidth = transform.localScale.x;
                Vector3 pointAround = transform.position + (Vector3.down * halfWidth) + (direction * halfWidth);
                Vector3 rollAxis = Vector3.Cross(Vector3.up, direction);
                Quaternion rotation = transform.rotation;
                Quaternion endRotation = rotation * Quaternion.Euler(rollAxis * rollAngle);
                Vector3 endPosition = transform.position + direction;

                float oldAngle = 0;

                while (rollDecimal < rollDuration)
                {
                    yield return new WaitForEndOfFrame();
                    rollDecimal += Time.deltaTime;
                    float newAngle = (rollDecimal / rollDuration) * rollAngle;
                    float rotateThrough = newAngle - oldAngle;
                    oldAngle = newAngle;
                    transform.RotateAround(pointAround, rollAxis, rotateThrough);

                }

                transform.position = endPosition;
                transform.rotation = endRotation;

                if (collision)
                {
                    transform.position = positionWithoutCollision;
                    transform.rotation = rotationWithoutCollision;
                    i = 3;
                }
            }
            shallIStop();

        }
        pressedTwoButtons = false;
        canStartRolling = true;
        collision = false;
        countWallsEnter = 2;

    }

}