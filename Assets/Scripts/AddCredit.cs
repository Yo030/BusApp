using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddCredit : MonoBehaviour
{
    public InputField field;
    private string input;
    public Text s_saldo;

    void addCredit(int _addedBalance)
    {
        switch (numeroTarjeta.tarjeta)
        {
            case 1:
                numeroTarjeta.saldo_1 += _addedBalance;

                s_saldo.text = "Tu saldo es: " + numeroTarjeta.saldo_1;
                break;
            case 2:
                numeroTarjeta.saldo_2 += _addedBalance;

                s_saldo.text = "Tu saldo es: " + numeroTarjeta.saldo_2;
                break;
            case 3:
                numeroTarjeta.saldo_3 += _addedBalance;

                s_saldo.text = "Tu saldo es: " + numeroTarjeta.saldo_3;
                break;
        }
    }

    public void setBalance()
    {
        input = field.text;
        int inputNum = 0;
        int.TryParse(input, out inputNum);
        addCredit(inputNum);
    }

    public void debugBalance()
    {
        Debug.Log("t1: " + numeroTarjeta.saldo_1);
        Debug.Log("t2: " + numeroTarjeta.saldo_2);
        Debug.Log("t3: " + numeroTarjeta.saldo_3);
    }

}


//
