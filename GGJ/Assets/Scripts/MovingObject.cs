using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public GameObject[] waypoints;
    private int currentWaypointIndex = 0;

    public float movementSpeed = 3f;


    void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < 0.1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
            switch(currentWaypointIndex)
            {
                case 0:
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                    break;
                case 1:
                    transform.rotation = Quaternion.Euler(0, 180, 0);
                    break;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, movementSpeed * Time.deltaTime);
    }
}
