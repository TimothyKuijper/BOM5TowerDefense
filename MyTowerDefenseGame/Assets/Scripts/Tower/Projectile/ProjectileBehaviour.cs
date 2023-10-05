using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    [SerializeField] public Transform target;
    private Rigidbody2D rb;
    public int damage;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * 20, ForceMode2D.Impulse);
        transform.parent = null;
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if (collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
