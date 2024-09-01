using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 2f; // ���� �̵� �ӵ�

    void Update()
    {
        Move();
    }

    void Move()
    {
        // ���� �Ʒ��� �̵�
        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // �÷��̾�� �浹 �� �ൿ (��: �÷��̾� ü�� ����, ���� ���� ��)
            Destroy(gameObject);
        }
        else if (other.CompareTag("Bullet"))
        {
            // �Ѿ˿� ������ �� �ı�
            Destroy(gameObject);
        }
    }
}
