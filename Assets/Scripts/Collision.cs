using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] private float timeDestroy = 1f;
    [SerializeField] private Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] private Color32 noPackageColor = new Color32(1, 1, 1,1);

    private SpriteRenderer _spriteRenderer;

    private bool _hasPackage;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Bumb!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package" && !_hasPackage)
        {
            Debug.Log("It's package");
            _hasPackage = true;
            _spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, timeDestroy);
        }

        if(other.tag == "Customer" && _hasPackage)
        {
            Debug.Log("Delivered!");
            _hasPackage = false;
            _spriteRenderer.color = noPackageColor;
        }
    }
}
