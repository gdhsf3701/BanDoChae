using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 2f; // 적의 이동 속도

    void Update()
    {
        Move();
    }

    void Move()
    {
        // 적이 아래로 이동
        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // 충돌한 객체가 "Bullet" 태그를 가졌는지 확인
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject); // 적 오브젝트 삭제
            Destroy(collision.gameObject); // 총알 오브젝트 삭제
        }
    }
}
