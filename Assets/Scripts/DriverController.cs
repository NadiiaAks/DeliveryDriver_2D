using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverController : MonoBehaviour
{
    private float _speedRotate = 0.5f;
    private float _speed = 0.3f;
    void Update()
    {
        transform.Rotate(0, 0, _speedRotate);
        transform.Translate (0, _speed, 0);
    }
}
