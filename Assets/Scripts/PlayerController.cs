using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float maxRotation;
    private float mouseX, mouseY;


    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            RotateMaze();
        }
    }

    void RotateMaze()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        float rotateX = mouseX * speed;
        float rotateZ = mouseY * speed;

        rotateX = Mathf.Clamp(rotateX, -maxRotation, maxRotation);
        rotateZ = Mathf.Clamp(rotateZ, -maxRotation, maxRotation);

        transform.eulerAngles = new Vector3(rotateZ, transform.rotation.y, rotateX);
    }
}
