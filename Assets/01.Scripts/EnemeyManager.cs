using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeyManager : MonoBehaviour
{
  
    private float currentTime = 0f;
    private float creatTime = 1f;
    public GameObject enemeyPrefab;
    private float minTime = 1f;
    private float maxTime = 3f;

    private void Start()
    {
        creatTime = UnityEngine.Random.Range(minTime, maxTime);
    }

    private void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime > creatTime)
        {
            currentTime = 0f;
            //GameObject enemy = Instantiate(enemeyPrefab);
            //enemy.transform.position = transform.position;
            GameObject enemy = Instantiate(enemeyPrefab, transform);
            creatTime = UnityEngine.Random.Range(minTime, maxTime);
        }
        
    }
  

}
