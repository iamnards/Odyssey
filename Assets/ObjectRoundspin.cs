using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRoundspin : MonoBehaviour
{
    public GameObject objectRotate;
    public float rotateSpeed = 50f;
    bool rotateStatus = false;

    public void RotateObject()
    {
        if (rotateStatus == false)
        {
            rotateStatus = true;
        }
        else
        {
            rotateStatus = false;
        }
    }

    void Update()
    {
        if (rotateStatus == true)
        {
            objectRotate.transform.Rotate(Vector3.right, rotateSpeed * Time.deltaTime);
        }
    }
}
