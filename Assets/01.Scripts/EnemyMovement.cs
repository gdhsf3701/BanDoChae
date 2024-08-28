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
        

        int value = UnityEngine.Random.Range(0, 10);
        if (value < 3) //30%Ȯ��
        {
            //�÷��̾� ��ġ - �� ��ġ
            GameObject target = GameObject.Find("Player");
            moveDir = target.transform.position - transform.position;
            moveDir.Normalize(); 
        }
        else //70%Ȯ��fh down
        {
            moveDir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += moveDir * speed * Time.deltaTime; //�̵�
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.CompareTag("Bullet"))
        {
           // sm.SetScore(ScoreManager.Instance.GetScore() + 1);
        //    int a = sm.GetScore()+1;
            
            Destroy(collision.gameObject);

        }
        Destroy(gameObject);
        
    }
}

