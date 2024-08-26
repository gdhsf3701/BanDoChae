using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS_ElectricDirectionCheck : MonoBehaviour
{
    private JS_DiodSwitching diodSwitching;

    private void Awake()
    {
        diodSwitching = GetComponent<JS_DiodSwitching>();
        diodSwitching.BanDoChae += SetVoltage;
    }

    private void SetVoltage(bool correct)
    {

    }
}
