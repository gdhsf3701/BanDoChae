using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class CreateBanDoChae : MonoBehaviour
{
    [SerializeField] GameObject NBanDoChae, PBanDoChae;
    [SerializeField] GameObject BanDoChaeInven;

    private bool complete;
    int temp = 0;

    public UnityEvent OnBanDoChae;
    public void SetBanDoChae()
    {
        if(BanDoChaeInven.transform.childCount == 0)
        {
            if (!complete)
            {
                temp = Random.Range(0, 2);
                GameObject banDoChae = Instantiate(temp == 0 ? NBanDoChae : PBanDoChae, BanDoChaeInven.transform);
                banDoChae.transform.localPosition = Vector3.zero;
                OnBanDoChae?.Invoke();
                complete = true;
            }
            else
            {
                temp = (temp + 1) % 2;
                GameObject banDoChae = Instantiate(temp == 0 ? NBanDoChae : PBanDoChae, BanDoChaeInven.transform);
                banDoChae.transform.localPosition = Vector3.zero;
                OnBanDoChae?.Invoke();
                complete = false;
            }
        }
    }
}
