using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTakeDamage : MonoBehaviour
{
    [SerializeField] private EnemyHealth enemyHealth;
    [SerializeField] private ProjectileBehaviour bullet;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            bullet = collision.gameObject.GetComponent<ProjectileBehaviour>();
            enemyHealth.Health = enemyHealth.Health - bullet.damage;
        }
    }
}
