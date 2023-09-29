using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] private Path path;
    [SerializeField] private float speed = 1;
    [SerializeField] private int nextWaypointIndex = 1;
    [SerializeField] private float reachedWaypointClearance = 0.25f;

    private void Awake()
    {
        path = FindAnyObjectByType<Path>();
    }

    void Start()
    {
        transform.position = path.waypoints[0].position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, path.waypoints[nextWaypointIndex].position, Time.deltaTime * speed);
        if (Vector3.Distance(transform.position, path.waypoints[nextWaypointIndex].position) <= reachedWaypointClearance) 
        {
            nextWaypointIndex++;
        }
        if (nextWaypointIndex >= path.waypoints.Length) 
        {
            Destroy(gameObject);
        }
    }
}
