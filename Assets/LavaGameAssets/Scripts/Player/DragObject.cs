using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class DragObject : MonoBehaviour

{

    private Vector3 mOffset;



    private float mZCoord;



    void OnMouseDown()

    {

        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;



        // Store offset = gameobject world pos - mouse world pos

        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();


    }



    private Vector3 GetMouseAsWorldPoint()

    {

        Vector3 mousePoint = Input.mousePosition;
        mousePoint.y = 1000;

        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);

    }



    void OnMouseDrag()

    {
        if (LavaGameManager.pause == false)
        {
            transform.position = GetMouseAsWorldPoint() + mOffset;
        }
    }

}