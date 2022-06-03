using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private bool _hasPackage;
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Bumb!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package")
        {
            Debug.Log("It's package");
            _hasPackage = true;
        }

        if(other.tag == "Customer" && _hasPackage)
        {
            Debug.Log("Delivered!");
            _hasPackage = false;
        }
    }
}
