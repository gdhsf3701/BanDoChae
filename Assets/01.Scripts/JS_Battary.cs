using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JS_Battary : MonoBehaviour
{
    [SerializeField] private GameObject Electron;
    [SerializeField] private GameObject PositiveHole;

    [SerializeField] private float createTime;

    [SerializeField] private JS_DiodSwitching switching;

    [SerializeField] private GameObject mother;

    private Coroutine coroutine;

    private void Awake()
    {
        switching.BanDoChae += StartMove;
    }
    public void StartMove(bool volt)
    {
        if (volt)
        {
            coroutine = StartCoroutine(SetVoltage());
        }
        else
        {
            StopCoroutine(coroutine);
            int x = mother.transform.childCount;
            for (int i = 0; i < x; i++)
            {
                Destroy(mother.transform.GetChild(i).gameObject);
            }
        }
    }

    IEnumerator SetVoltage()
    {
        for(int i  = 0; i < 21; i++)
        {
            yield return new WaitForSeconds(createTime);
            Instantiate(Electron, transform.position, Quaternion.identity ,mother.transform);
            Instantiate (PositiveHole, transform.position, Quaternion.identity, mother.transform);
        }
    }
}
