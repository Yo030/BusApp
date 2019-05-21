using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoDeEsperaParaRecarga : MonoBehaviour
{
    /*
    public float TiemDeEspera;
    public float TiemDeEsperaDesDeVibrar;
    public GameObject Parte5;
    */

    void Start()
    {

        Handheld.Vibrate();
    }
    /*
    void Update()
    {
        TiemDeEspera += TiemDeEspera * Time.deltaTime - 1;
        if (TiemDeEspera <= 0)
        {
            //Activar vibracion

            TiemDeEsperaDesDeVibrar += TiemDeEsperaDesDeVibrar * Time.deltaTime - 1;
            if (TiemDeEsperaDesDeVibrar <= 0)
            {
                Parte5.SetActive(true);
            }
        }
    }*/
}

