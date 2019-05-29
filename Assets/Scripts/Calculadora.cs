using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class Calculadora : MonoBehaviour
{
    private string s_saldo = "";
    private int n_saldo;
    public Text text;
    public GameObject wondow;

    public void agregarNumero(string _n)
    {
        if (s_saldo.Length <= 2)
        {
            s_saldo += _n;
            text.text = s_saldo;
        }
    }

    public void borrarNumero()
    {
        if (s_saldo.Length >= 1)
        {
            s_saldo = s_saldo.Substring(0, s_saldo.Length - 1);
            text.text = s_saldo;
        }
    }

    public void addCredit(int _addedBalance)
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

        SaldoInfo saldo = new SaldoInfo(numeroTarjeta.saldo_1, numeroTarjeta.saldo_2, numeroTarjeta.saldo_3);
        saveData(saldo);
    }

    public void okSaldo()
    {

        int n_saldo = 0;
        int.TryParse(s_saldo, out n_saldo);
        if (n_saldo > 300)
        {
            text.text = "0";
            n_saldo = 0;
            s_saldo = "";
            wondow.SetActive(true);
        }
        else
        {
            addCredit(n_saldo);
            text.text = "";
            s_saldo = "";
        }
        Debug.Log(n_saldo);
        Debug.Log(s_saldo);
    }

    void saveData(SaldoInfo data)
    {
        //string json = JsonUtility.ToJson(data, true);

        File.WriteAllText(Application.persistentDataPath + "/saldoInfo.Qro", JsonUtility.ToJson(data, true));
    }
}


//value = value.Substring(0, value.Length - 1);