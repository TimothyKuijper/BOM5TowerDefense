using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetermineIfPath : MonoBehaviour
{
    [SerializeField] public bool notOnPath = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("path"))
        {
            notOnPath = false;
        }
    }
}
