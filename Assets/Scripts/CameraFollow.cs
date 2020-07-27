using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform _target;
    public float _sensitivity = 1;

    // Update is called once per frame
    void Update()
    {
        //двигаемся вслед за целью
        transform.position = _target.position;

        float rot = Input.GetAxis("Mouse X");
        if (rot != 0)
        {
            RotateAround(rot);
        }
    }

    private void RotateAround(float value)
    {
        transform.Rotate(0, value * _sensitivity, 0);
    }
}
