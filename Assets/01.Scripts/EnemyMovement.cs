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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // 플레이어와 충돌 시 행동 (예: 플레이어 체력 감소, 게임 오버 등)
            Destroy(gameObject);
        }
        else if (other.CompareTag("Bullet"))
        {
            // 총알에 맞으면 적 파괴
            Destroy(gameObject);
        }
    }
}
