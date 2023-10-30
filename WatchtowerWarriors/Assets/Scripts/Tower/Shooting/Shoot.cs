using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] GetEnemy getEnemy;
    [SerializeField] private GameObject bullet;
    private GameObject bulletClone;

    IEnumerator Shooting()
    {
        while (true) 
        { 
            if (getEnemy.target != null)
            {
                Instantiate(bullet, transform);
            }
            yield return new WaitForSeconds(1f);
        }
    }

    public void StartShooting()
    {
        StartCoroutine(Shooting());
    }
}