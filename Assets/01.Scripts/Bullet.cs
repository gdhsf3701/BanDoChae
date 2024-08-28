using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 10f;
   
    void Update()
    {
        transform.position +=Vector3.up * speed * Time.deltaTime;
    }
}
