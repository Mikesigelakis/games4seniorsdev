using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void RotateLeft()
    {
        transform.Rotate(Vector2.up * 250 * Time.deltaTime);
    }
    public void RotateRight()
    {
        transform.Rotate(Vector2.down * 250 * Time.deltaTime);
    }

    public void RotateUp()
    {
        transform.Rotate(Vector2.right * 250 * Time.deltaTime);
    }

    public void RotateDown()
    {
        transform.Rotate(Vector2.left * 250 * Time.deltaTime);
    }
}
