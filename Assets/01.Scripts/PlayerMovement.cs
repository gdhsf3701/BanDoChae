using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    private Transform _transform1;
    private Transform _transform2;
    private Camera mainCam;
    private float leftLimit;
    private float rightLimit;
    private float downLimit;
    private float upLimit;

   // [SerializeField] private GameObject gameOverUI;

    private void Start()
    {
        mainCam = Camera.main;
        leftLimit = mainCam.ViewportToWorldPoint(new Vector2(0, 0)).x; //viewport change to worldpoint 
        rightLimit = mainCam.ViewportToWorldPoint(new Vector2(1, 1)).x;

        downLimit = mainCam.ViewportToWorldPoint(new Vector2(0, 0)).y;
        upLimit = mainCam.ViewportToWorldPoint(new Vector2(1, 1)).y;


    }

    private void Awake()
    {
        _transform1 = GetComponent<Transform>();
    }
    private void Update()
    {
        //input manager
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 moveDir = new Vector3(h, v, 0);
        transform.position += moveDir * 5 * Time.deltaTime; //¿Ãµø   
    }
    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, leftLimit, rightLimit), transform.position.y, 0);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      //  gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
