using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemyPrefab; // 적 프리팹
    public float spawnInterval = 2f;  // 적 생성 간격

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
        // 적을 스폰할 위치 결정 (예: 화면 상단에서 랜덤한 x좌표)
        Vector2 spawnPosition = new Vector2(Random.Range(-8f, 8f), 6f);

        // 적 생성
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
