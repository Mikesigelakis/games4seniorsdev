using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public static float movementSpeed;

    void Update()
    {
        if (LavaGameManager.pause == false)
        {
            float randomValue = Random.Range(0f, 10.0f);
            if (randomValue < 5.01f)
            {
                transform.position += Vector3.back * movementSpeed * Time.deltaTime;
            }
            else
            {
                transform.position += Vector3.back * (movementSpeed+0.8f) * Time.deltaTime;   
            }
        }
    }
}
