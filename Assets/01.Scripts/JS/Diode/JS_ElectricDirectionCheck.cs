using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JS_ElectricDirectionCheck : MonoBehaviour
{
    private JS_DiodSwitching diodSwitching;
    [SerializeField] private SpriteRenderer DiodSprite;

    private void Awake()
    {
        diodSwitching = GetComponent<JS_DiodSwitching>();
        diodSwitching.BanDoChae += SetVoltage;
    }

    private void SetVoltage(bool correct)
    {
        if(correct)
        {
            Debug.Log("전압 설정 완료");
        }
        DiodSprite.flipX = correct;
    }
}
