using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeCard : MonoBehaviour
{
    public InputField cardNumber;
    public Image typeCard;
    public Sprite masterCard;
    public Sprite visaCard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cardNumber.text.Length >= 6)
        {
            //Debug.Log("numero input: " + cardNumber.text.Length);
            if (cardNumber.text[0] == '4')
            {
                //Debug.Log("visa");
                typeCard.sprite = visaCard;
            }

            if (cardNumber.text[0] == '5')
            {
                //Debug.Log("mastercard");
                if (cardNumber.text[1] >= '1' && cardNumber.text[1] <= '5')
                {
                    typeCard.sprite = masterCard;
                }
            }
        }
        else
        {
            typeCard.sprite = null;
        }
    }
}
