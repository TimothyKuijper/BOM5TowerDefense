using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Aim : MonoBehaviour
{
    [SerializeField] GetEnemy getEnemy;

    void Update()
    {
        if (getEnemy.target == null) { return; }
        Vector2 direction = getEnemy.target.transform.position - transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector3.up, direction);
    }
}
