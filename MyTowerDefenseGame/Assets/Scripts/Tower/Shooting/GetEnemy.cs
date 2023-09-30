using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetEnemy : MonoBehaviour
{
    [SerializeField] public GameObject Target;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == null){ return; }

        if (Target != null) { return; }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Target = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == Target)
        {
            Target = null;
        }
    }
}
