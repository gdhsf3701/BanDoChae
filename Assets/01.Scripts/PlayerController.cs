using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject[] bulletPrefabs; // �Ѿ� ������ �迭
    public Transform firePoint;
    [SerializeField]GameObject gameOver;

    void Update()
    {
        Move();
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            GameOver();
        }
    }

    void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveX, moveY) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOver.SetActive(true);

    }
    private void Awake()
    {
       gameOver.SetActive(false);
    }
    void Shoot()
    {
        // �� ���� �Ѿ� �� �ϳ��� �������� ����
        int randomIndex = Random.Range(0, bulletPrefabs.Length);
        GameObject selectedBullet = bulletPrefabs[randomIndex];

        Instantiate(selectedBullet, firePoint.position, firePoint.rotation);
    }
}
