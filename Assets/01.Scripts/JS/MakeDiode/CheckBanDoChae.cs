using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckBanDoChae : MonoBehaviour
{
    [SerializeField] private GameObject slot1, slot2;

    private bool s1,s2;

    public UnityEvent<string> OnValChange;
    public UnityEvent Complete;

    public int BanDoChaeCount; 
    public void CheckSlot()
    {
        if(slot1.transform.childCount != 0)
        {
            if(slot1.transform.GetChild(0).CompareTag("N"))
            {
                s1 = true;
            }
            if (slot1.transform.GetChild(0).CompareTag("P"))
            {
                s2 = true;
            }
        }
        if (slot2.transform.childCount != 0)
        {
            if (slot2.transform.GetChild(0).CompareTag("P"))
            {
                s2 = true;
            }
            if (slot2.transform.GetChild(0).CompareTag("N"))
            {
                s1 = true;
            }
        }
        if (s1&&s2)
        {
            Destroy(slot1.transform.GetChild(0).gameObject);
            Destroy(slot2.transform.GetChild(0).gameObject);

            s1= false;
            s2 = false;
            BanDoChaeCount++;
            OnValChange?.Invoke($"반도체 두 개를 이어붙여\r\n다이오드 만들기 {BanDoChaeCount}/5");
            if (BanDoChaeCount >= 5)
            {
                Complete?.Invoke();
            }
        }
    }
}
