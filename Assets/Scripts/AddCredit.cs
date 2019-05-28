using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class AddCredit : MonoBehaviour
{
    public InputField field;
    private string input;
    public Text s_saldo;
    public GameObject wondow;

    public void addCredit(int _addedBalance)
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

        SaldoInfo saldo = new SaldoInfo(numeroTarjeta.saldo_1, numeroTarjeta.saldo_2, numeroTarjeta.saldo_3);
        saveData(saldo);
        
    }

    void saveData(SaldoInfo data)
    {
        //string json = JsonUtility.ToJson(data, true);
        
        File.WriteAllText(Application.persistentDataPath + "/saldoInfo.Qro", JsonUtility.ToJson(data, true));
    }

    public void setBalance()
    {
        input = field.text;
        int inputNum = 0;
        int.TryParse(input, out inputNum);
        if (inputNum > 300)
        {
            field.text = "300";
            wondow.SetActive(true);
        }
        else
        {
            addCredit(inputNum);
            field.text = "";
        }
    }

    public void debugBalance()
    {
        Debug.Log("t1: " + numeroTarjeta.saldo_1);
        Debug.Log("t2: " + numeroTarjeta.saldo_2);
        Debug.Log("t3: " + numeroTarjeta.saldo_3);
    }

}


//
