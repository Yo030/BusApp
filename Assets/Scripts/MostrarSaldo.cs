using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MostrarSaldo : MonoBehaviour
{
    public Text text;

   
    void Update()
    {
        text.text = MuestraSaldo();
    }
    

    public string MuestraSaldo()
    {
        float saldo = 0;

        if (numeroTarjeta.tarjeta == 1)
        {
            saldo = numeroTarjeta.saldo_1;
        } else if (numeroTarjeta.tarjeta == 2)
        {
            saldo = numeroTarjeta.saldo_2;
        } else if (numeroTarjeta.tarjeta == 3)
        {
            saldo = numeroTarjeta.saldo_3;
        }


        string stringSaldo = saldo.ToString();

        stringSaldo = "$" + stringSaldo;

        return stringSaldo;
    }
}


/*
 TextMeshProUGUI TextPro;
     TextPro.text = "Some String";
     
     */
