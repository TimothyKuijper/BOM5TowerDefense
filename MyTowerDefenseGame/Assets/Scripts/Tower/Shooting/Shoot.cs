using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] GetEnemy getEnemy;
    [SerializeField] private GameObject bullet;
    private GameObject bulletClone;
    void Start()
    {
        StartCoroutine(Shooting());
    }

    void Update()
    {

    }

    IEnumerator Shooting()
    {
        while (true) 
        {
            if (getEnemy.target != null)
            {
                Instantiate(bullet, transform);
                    yield return new WaitForSeconds(0.5f);
            }
            yield return null;
        }
    }
}