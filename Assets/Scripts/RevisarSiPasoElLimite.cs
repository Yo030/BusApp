using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RevisarSiPasoElLimite : MonoBehaviour
{
    [SerializeField]
    private InputField inputMonto;
    public GameObject AdvertenciaDeLimite;


    void Update()
    {
        inputMonto.onEndEdit.AddListener(delegate {LockInput(float.Parse(inputMonto.text), inputMonto);});
    }
    void LockInput(float Tam, InputField Calificacion)
    {
        if (Tam >= 300)
        {
            Calificacion.text = "0";
            AdvertenciaDeLimite.SetActive(true);
        }
    }

}
