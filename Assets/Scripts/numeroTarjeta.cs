using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class numeroTarjeta
{
    public static int tarjeta = 1;

    public static float saldo_1 = 0;
    public static float saldo_2 = 0;
    public static float saldo_3 = 0;

    public numeroTarjeta()
    {

    }

    public numeroTarjeta(float saldo1, float saldo2, float saldo3)
    {
        saldo_1 = saldo1;
        saldo_2 = saldo2;
        saldo_3 = saldo3;
    }

    public float getSaldo1()
    {
        return saldo_1;
    }

    public float getSaldo2()
    {
        return saldo_2;
    }
    public float getSaldo3()
    {
        return saldo_3;
    }
}
