using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Camera cam;
    public static int levelGame;
    private static float orthoGraphicSize;
    private static float positionAxisX;
    private static float positionAxisZ;



    void Start()
    {
        orthoGraphicSize = cam.orthographicSize;
        positionAxisX = cam.transform.position.x;
        positionAxisZ = cam.transform.position.z;
        
        

        for (int i = 3; i < levelGame; i++)
        {
            orthoGraphicSize = orthoGraphicSize + 1;
            positionAxisX = positionAxisX + 1.2f;
            positionAxisZ = positionAxisZ + 1f;
        }

        cam.orthographicSize = orthoGraphicSize;
        cam.transform.position = new Vector3(positionAxisX, cam.transform.position.y, positionAxisZ);
    }

}

