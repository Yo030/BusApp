using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseRoute : MonoBehaviour
{
    public Dropdown routeContainer;

    public List<GameObject> route = new List<GameObject>();

    public void SetRoute()
    {
        switch(routeContainer.value)
        {
            case 1:
                route[0].SetActive(true);
                route[1].SetActive(false);
                break;
            case 2:
                route[0].SetActive(false);
                route[1].SetActive(true);
                break;
        }
    }
}
