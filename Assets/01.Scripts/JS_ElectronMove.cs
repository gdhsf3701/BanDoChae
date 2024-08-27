using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS_ElectronMove : MonoBehaviour
{
    [SerializeField] private JS_WaypointSO waypointSO;
    private Vector3 currentPosition;
    private int waypointIndexer = 0;

    [SerializeField] float speed = 3f;

    private void FixedUpdate()
    {
        currentPosition = transform.position;


        if (waypointIndexer < waypointSO.waypoints.Count)
        {
            float step = speed;

            transform.position = Vector3.MoveTowards(transform.position, waypointSO.waypoints[waypointIndexer], step);

            if (Vector3.Distance(waypointSO.waypoints[waypointIndexer], currentPosition) == 0f)
                waypointIndexer++;
        }
        else
        {
            waypointIndexer = 0;
        }
    }
}
