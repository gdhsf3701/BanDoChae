using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private float moveSpeed = 3.0f;
    private float scrollRange = 9.9f;
    public GameObject target;
    void Update()
    {
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        if (transform.position.y <= -scrollRange)
        {
            transform.position = target.transform.position + Vector3.up * scrollRange;
        }
    }
}
