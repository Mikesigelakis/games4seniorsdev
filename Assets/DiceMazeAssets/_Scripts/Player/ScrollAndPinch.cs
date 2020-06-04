using UnityEngine;

class ScrollAndPinch : MonoBehaviour
{

    public Camera cam;
    public bool Rotate;
    protected Plane plane;
    public static int level;
    private float limitZ1;
    private float limitZ2;
    private float limitX1;
    private float limitX2;

    private void Start()
    {
        limitX1 = 3.7f;
        limitX2 = -1.5f;
        limitZ1 = 3.229f;
        limitZ2 = -5.579f;

        for (int i = 3; i < level; i++)
        {
            limitX1 = limitX1 + 1.2f;
            limitX2 = limitX2 + 1.2f;
            limitZ1 = limitZ1 + 1f;
            limitZ2 = limitZ2 + 1f;
        }
    }

    private void Update()
    {
        if (Input.touchCount >= 2)
        {
            float distanceBetweenTouches = Mathf.Abs(Input.touches[0].position.x - Input.touches[1].position.x);
            Debug.Log(distanceBetweenTouches);
            if (distanceBetweenTouches < 200)
            {
                MoveCamera();
            }
            else
            {
                Zoom();
            }
        }
    }

    private void Zoom()
    {

        Touch firstTouch = Input.GetTouch(0);
        Touch secondTouch = Input.GetTouch(1);
        Vector2 firstTouchPrevPos, secondTouchPrevPos;
        float zoomModifierSpeed = 0.01f;
        float touchesPrevPosDifference, touchesCurPosDifference, zoomModifier;
        firstTouchPrevPos = firstTouch.position - firstTouch.deltaPosition;
        secondTouchPrevPos = secondTouch.position - secondTouch.deltaPosition;

        touchesPrevPosDifference = (firstTouchPrevPos - secondTouchPrevPos).magnitude;
        touchesCurPosDifference = (firstTouch.position - secondTouch.position).magnitude;

        zoomModifier = (firstTouch.deltaPosition - secondTouch.deltaPosition).magnitude * zoomModifierSpeed;
        if (touchesPrevPosDifference > touchesCurPosDifference)
        {
            if (cam.orthographicSize > 12.2f) return;
            cam.orthographicSize += zoomModifier;
        }

        if (touchesPrevPosDifference < touchesCurPosDifference)
        {if (cam.orthographicSize < 1) return;
            cam.orthographicSize -= zoomModifier;
        
            }

    }



    private void MoveCamera()
    {
        if (Camera.main.transform.position.x > limitX1)
        {
            cam.transform.position = new Vector3(limitX1 - 0.2f, Camera.main.transform.position.y, Camera.main.transform.position.z);
            return;
        }
        if (Camera.main.transform.position.x < limitX2)
        {
            cam.transform.position = new Vector3(limitX2 + 0.2f, Camera.main.transform.position.y, Camera.main.transform.position.z);
            return;
        }
        if (Camera.main.transform.position.z > limitZ1)
        {
            cam.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, limitZ1 - 0.2f);
            return;
        }
        if (Camera.main.transform.position.z < limitZ2)
        {
            cam.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, limitZ2 + 0.2f);
            return;
        }


        plane.SetNormalAndPosition(transform.up, transform.position);
        var Delta1 = Vector3.zero;
        Delta1 = PlanePositionDelta(Input.GetTouch(0));
        if (Input.GetTouch(0).phase == TouchPhase.Moved) cam.transform.Translate(Delta1, Space.World);

    }

    protected Vector3 PlanePositionDelta(Touch touch)
    {
        //not moved
        if (touch.phase != TouchPhase.Moved)
            return new Vector3(1.71f, -1.64f, 2.61f);

        //delta
        var rayBefore = cam.ScreenPointToRay(touch.position - touch.deltaPosition);
        var rayNow = cam.ScreenPointToRay(touch.position);
        if (plane.Raycast(rayBefore, out var enterBefore) && plane.Raycast(rayNow, out var enterNow))
            return rayBefore.GetPoint(enterBefore) - rayNow.GetPoint(enterNow);

        //not on plane
        return new Vector3(1.71f, -1.64f, 2.61f);
    }

    protected Vector3 PlanePosition(Vector2 screenPos)
    {
        //position
        var rayNow = cam.ScreenPointToRay(screenPos);
        if (plane.Raycast(rayNow, out var enterNow))
            return rayNow.GetPoint(enterNow);

        return new Vector3(1.71f, -1.64f, 2.61f);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, transform.position + transform.up);
    }
}