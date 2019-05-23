using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddCredit : MonoBehaviour
{
    public InputField field;
    private string input;

    void addCredit(int _addedBalance)
    {
        switch (numeroTarjeta.tarjeta)
        {
            case 1:
                numeroTarjeta.saldo_1 += _addedBalance;
                break;
            case 2:
                numeroTarjeta.saldo_2 += _addedBalance;
                break;
            case 3:
                numeroTarjeta.saldo_3 += _addedBalance;
                break;
        }
    }

    public void setBalance()
    {
        input = field.text;
        int inputNum = 0;
        int.TryParse(input, out inputNum);

        addCredit(inputNum);
        Debug.Log(inputNum+1);
    }

    public void debugBalance()
    {
        Debug.Log(numeroTarjeta.saldo_1);
    }

}


//
