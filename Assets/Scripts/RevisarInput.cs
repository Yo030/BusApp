using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RevisarInput : MonoBehaviour
{

    public Text Txt_Confirmacion;
    public InputField InputMonto;

    void Update()
    {
        Txt_Confirmacion.text = "ESTAS SEGURO DE QUE QUIERES INGRESAR: " + float.Parse(InputMonto.text) + " PESOS A TU TARJETA?";
    }

}
