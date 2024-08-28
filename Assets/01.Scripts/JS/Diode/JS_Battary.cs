using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class JS_Battary : MonoBehaviour
{
    [SerializeField] private GameObject Electron;
    [SerializeField] private GameObject PositiveHole;
    [SerializeField] private GameObject NegativeUnConnect, PositiveUnConnect;

    [SerializeField] private float createTime;

    [SerializeField] private JS_DiodSwitching switching;

    [SerializeField] private GameObject mother, Panal;
    public UnityEvent<int> OnBattaryEvent;

    private Coroutine coroutine;

    private void Awake()
    {
        switching.BanDoChae += StartMove;
    }
    public void StartMove(bool volt)
    {
        Panal.SetActive(!volt);
        if (volt)
        {
            OnBattaryEvent?.Invoke(1);
            if (coroutine != null)
            {
                StopCoroutine(coroutine);
            }
            int x = mother.transform.childCount;
            for (int i = 0; i < x; i++)
            {
                Destroy(mother.transform.GetChild(i).gameObject);
            }
            coroutine = StartCoroutine(SetVoltage());
        }
        else
        {
            OnBattaryEvent?.Invoke(0);

            if (coroutine != null)
            {
                StopCoroutine(coroutine);
            }
            int x = mother.transform.childCount;
            for (int i = 0; i < x; i++)
            {
                Destroy(mother.transform.GetChild(i).gameObject);
            }

            coroutine = StartCoroutine(SetUnVoltage());
        }
    }

    IEnumerator SetVoltage()
    {
        while (true)
        {
            yield return new WaitForSeconds(createTime);
            Instantiate(Electron, transform.position, Quaternion.identity, mother.transform);
            Instantiate(PositiveHole, transform.position, Quaternion.identity, mother.transform);
        }
    }

    IEnumerator SetUnVoltage()
    {
        while (true)
        {
            yield return new WaitForSeconds(createTime);
            Instantiate(PositiveUnConnect, transform.position, Quaternion.identity, mother.transform);
            Instantiate(NegativeUnConnect, transform.position, Quaternion.identity, mother.transform);
        }
    }
}
