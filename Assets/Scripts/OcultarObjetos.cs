using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OcultarObjetos : MonoBehaviour
{
    public GameObject[] Ocultar;
    public GameObject[] Aparecer;

    public void OcultarLista()
    {
        for (int i = 0; i  < Ocultar.Length; i++)
        {
            Ocultar[i].SetActive(false);
        }
    }

    public void AparecerLista()
    {
        for (int i = 0; i < Aparecer.Length; i++)
        {
            Aparecer[i].SetActive(true);
        }
    }

}
