using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetEnemy : MonoBehaviour
{
    [SerializeField] public GameObject target;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == null){ return; }

        if (target != null) { return; }

        if (target == null && collision.gameObject.CompareTag("Enemy"))
        {
            target = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == target)
        {
            target = null;
        }
    }
}
