using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TowerBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private GameObject[] targets;
    [SerializeField] private Transform target;
    [SerializeField] private float shootInterval = 1;
    [SerializeField] private int random;
    void Start()
    {
        StartCoroutine(Shoot());
    }

    void Update()
    {
        
        targets = GameObject.FindGameObjectsWithTag("Enemy");
        if (targets.Length == 0) { return; }
        target = targets[0].transform;
        LookAtTarget(target);
    }

    void LookAtTarget(Transform target)
    {
        Vector2 direction = target.position - transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector3.up, direction);
    }

    IEnumerator Shoot()
    {
        while (true) {
            GameObject projectileClone = Instantiate(projectilePrefab, gameObject.transform);
            ProjectileBehaviour projectile = projectileClone.GetComponent<ProjectileBehaviour>();
            projectile.target = target;
            yield return new WaitForSeconds(shootInterval); 
        }
    }
}