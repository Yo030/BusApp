using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class SaveInfo : MonoBehaviour
{
    private string name;
    private string month;
    private string year; 
    private string number;
    private string security;
    
    private double[] numberCard = new double[16];
    private int validCard;

    public InputField NameField;
    public InputField MonthField;
    public InputField YearField;
    public InputField NumberField;
    public InputField SecurityField;

    public void saveInfo()
    {
        if (NumberField.text.Length == 16)
        {
            for (int i = 0; i < NumberField.text.Length; i++)
            {
                numberCard[i] = char.GetNumericValue(NumberField.text[i]);
                if (i % 2 == 0)
                {
                    //Debug.Log(numberCard[i]);
                    switch (numberCard[i])
                    {
                        case 5:
                            numberCard[i] = 1;
                            break;
                        case 6:
                            numberCard[i] = 3;
                            break;
                        case 7:
                            numberCard[i] = 5;
                            break;
                        case 8:
                            numberCard[i] = 7;
                            break;
                        case 9:
                            numberCard[i] = 9;
                            break;
                        default:
                            numberCard[i] += numberCard[i];
                            break;
                    }
                    
                }
                Debug.Log(numberCard[i]);
                validCard += Convert.ToInt32(numberCard[i]);
                
            }
            Debug.Log("Valid Card: " + validCard);

        }
        else
        {
            Debug.Log("numero no valido");
        }

        Debug.Log(validCard);
        number = NumberField.text;
        name = NameField.text;
        month = MonthField.text;
        year = YearField.text;
        security = SecurityField.text;

        if ((validCard == 70 || validCard == 80 || validCard == 90 || validCard == 100 || validCard == 60) && name != "" && month != "" && year != "" && security != "")
        {
            CardInfo card = new CardInfo(name, month, year, number, security);
            BinaryFormatter bf = new BinaryFormatter();
            Debug.Log(Application.persistentDataPath);
            FileStream file = File.Create(Application.persistentDataPath + "/CardInfo.txt");
            bf.Serialize(file, card);
            file.Close();
            
        }

        validCard = 0;
    }
}
