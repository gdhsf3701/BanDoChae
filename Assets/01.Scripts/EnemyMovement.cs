using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Vector3 moveDir;
    private float speed = 5f;
  //  public ScoreManager sm;

   

    private void Awake()
    {
      ///  sm = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void Start()
    {
        

        
            //플레이어 위치 - 내 위치
            GameObject target = GameObject.Find("Player");
        if (target = null)
        {
            Time.timeScale = 0f;
        }
            moveDir = target.transform.position - transform.position;
            moveDir.Normalize(); 
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += moveDir * speed * Time.deltaTime; //이동
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.CompareTag("Bullet"))
       {
  
            Destroy(collision.gameObject);

       }

        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
       
    }
}

