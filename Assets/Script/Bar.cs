using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    float newXPosition, newYPosition, newZPosition;
    // Start is called before the first frame update
    void Start()
    {
        newXPosition = transform.position.x;
        newYPosition = transform.position.y;
        newZPosition = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            newXPosition = transform.position.x - 0.01f;
            transform.position = new Vector3(newXPosition, newYPosition, newZPosition);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            newXPosition = transform.position.x + 0.01f;
            transform.position = new Vector3(newXPosition, newYPosition, newZPosition);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            newYPosition = transform.position.y + 0.01f;
            transform.position = new Vector3(newXPosition, newYPosition, newZPosition);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            newYPosition = transform.position.y - 0.01f;
            transform.position = new Vector3(newXPosition, newYPosition, newZPosition);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            newZPosition = transform.position.z + 0.01f;
            transform.position = new Vector3(newXPosition, newYPosition, newZPosition);
        }

    }

}
