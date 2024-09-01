using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bulletPrefab2;
    private bool isSpecila = false;
    public GameObject firePos;


    //1.발사버튼을 누르면
    //2.총알 생성
    //3. 발사


    void Update()
    {
        int a = Random.Range(1, 3);
        if (a == 1)
        {
            isSpecila = false;
        }
        else if (a == 2)
            isSpecila = true;

        if (isSpecila = false)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                GameObject bullet = Instantiate(bulletPrefab);
                bullet.transform.position = firePos.transform.position;
                StartCoroutine(Destroy());


            }
        }
        else if(isSpecila = true)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                GameObject bullet = Instantiate(bulletPrefab2);
                bullet.transform.position = firePos.transform.position;
                StartCoroutine(Destroy());


            }
        }
        
    }
    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

}
