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

    void OnTriggerEnter2D(Collider2D collision)
    {
        // �浹�� ��ü�� "Bullet" �±׸� �������� Ȯ��
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject); // �� ������Ʈ ����
            Destroy(collision.gameObject); // �Ѿ� ������Ʈ ����
        }
    }
}
