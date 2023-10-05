using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] public int Health;
    [SerializeField] private ProjectileBehaviour bullet;
    void Start()
    {

    }

    void Update()
    {
        if (Health < 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            bullet = collision.gameObject.GetComponent<ProjectileBehaviour>();
            Health -= bullet.damage;
        }
    }
}