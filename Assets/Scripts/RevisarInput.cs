using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RevisarInput : MonoBehaviour
{
    [SerializeField]
    private InputField Monto;

    public Text Confirmacion;

    void LimiteDeRecarga(float Tam, InputField Calificacion)
    {
        if (Tam >= 11)
        {
            Calificacion.text = "300";
        }
    }

    void Update()
    {
        Confirmacion.text = "Estas segurao que quieres ingresar :" + Monto + "?";
    }

}
