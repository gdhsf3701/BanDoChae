using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject firePos;


    //1.�߻��ư�� ������
    //2.�Ѿ� ����
    //3. �߻�


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.transform.position = firePos.transform.position;


        }
    }

}
