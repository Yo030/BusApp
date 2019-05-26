using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CargarSaldo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (File.Exists(Application.persistentDataPath + "/saldoInfo.Qro"))
        {
            //numeroTarjeta SaldoAnteiror = new numeroTarjeta();
            string json = File.ReadAllText(Application.persistentDataPath + "/saldoInfo.Qro");
            SaldoInfo cargarSaldo = JsonUtility.FromJson<SaldoInfo>(json);

            numeroTarjeta.saldo_1 = cargarSaldo.saldo1;
            numeroTarjeta.saldo_2 = cargarSaldo.saldo2;
            numeroTarjeta.saldo_3 = cargarSaldo.saldo3;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
