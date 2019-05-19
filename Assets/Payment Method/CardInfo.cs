using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CardInfo
{
    private string name;
    private string Month;
    private string Year;
    private string Number;
    private string security;

    public CardInfo(string _name, string _month, string _year, string _Number, string _security)
    {
        name = _name;
        Month = _month;
        Year = _year;
        Number = _Number;
        security = _security;
    }
}
