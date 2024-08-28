using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS_DiodSwitching : MonoBehaviour
{
    private bool _banDoChaeIsCurrect = false;
    public event Action<bool> BanDoChae;

    public void Switching()
    {
        _banDoChaeIsCurrect = !_banDoChaeIsCurrect;
        
    }

    public void SendEvent() 
    { 
        BanDoChae?.Invoke(_banDoChaeIsCurrect);
    }
}
