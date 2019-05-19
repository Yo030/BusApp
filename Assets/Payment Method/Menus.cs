using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public GameObject advertencia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void gotoMenu(string menu)
    {
        SceneManager.LoadScene(menu);
    }

    public void recargarTrajeta(string charge)
    {
        if (File.Exists(Application.persistentDataPath + "/CardInfo.txt"))
        {
            SceneManager.LoadScene(charge);
        }
        else
        {
            advertencia.SetActive(true);
        }
    }

    public void desactivarMenu()
    {
        advertencia.SetActive(false);
    }
}
