using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject firePos;


    //1.발사버튼을 누르면
    //2.총알 생성
    //3. 발사


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.transform.position = firePos.transform.position;


        }
    }

}
