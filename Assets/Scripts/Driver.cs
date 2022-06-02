using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 0.5f;
    [SerializeField] private float moveSpeed = 0.3f;

    private float _rotateAmount;
    private float _moveAmount;

        
    void Update()
    {
        _rotateAmount = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        _moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -_rotateAmount);
        transform.Translate(0, _moveAmount, 0);
    }

}
