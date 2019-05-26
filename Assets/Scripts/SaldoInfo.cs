using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SaldoInfo 
{
    public float saldo1;
    public float saldo2;
    public float saldo3;

    public SaldoInfo(float _saldo1, float _saldo2, float _saldo3)
    {
        saldo1 = _saldo1;
        saldo2 = _saldo2;
        saldo3 = _saldo3;
    }
}
