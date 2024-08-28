using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class JS_BanDoChaeTypeChecker : MonoBehaviour
{
    JS_SlotScript slot;
    [SerializeField] private GameObject bando;
    [SerializeField] private GameObject chae;
    [SerializeField] private GameObject dochae;

    public UnityEvent<int> OnCompleteType;
    private void Awake()
    {
        slot = GetComponent<JS_SlotScript>();
        slot.OnDroped += SetState;
    }

    private void SetState(GameObject target)
    {
        if (target.name == "N-Type")
        {
            SetText_N();
        }
        else if (target.name == "P-Type") SetText_P();
        else 
        {
            chae.SetActive(false);
            bando.SetActive(false);
            dochae.SetActive(true);
        };
    }

    private void SetText_N()
    {
        chae.SetActive(false);
        dochae.SetActive(false);
        bando.SetActive(true);
        OnCompleteType?.Invoke(0);
    }
    private void SetText_P()
    {
        chae.SetActive(true);
        dochae.SetActive(false);
        bando.SetActive(false);
        OnCompleteType?.Invoke(1);
    }
}
