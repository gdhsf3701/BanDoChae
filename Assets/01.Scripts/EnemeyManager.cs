using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemyPrefab; // �� ������
    public float spawnInterval = 2f;  // �� ���� ����

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    void SpawnEnemy()
    {
        // ���� ������ ��ġ ���� (��: ȭ�� ��ܿ��� ������ x��ǥ)
        Vector2 spawnPosition = new Vector2(Random.Range(-8f, 8f), 6f);

        // �� ����
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
