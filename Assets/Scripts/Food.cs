using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food : MonoBehaviour
{
    public Text amountText;
    

    public static int amountFood;

    private void OnEnable()
    {
        amountFood = Random.Range(1, 10);
        amountText.text = amountFood.ToString();
    }

    
}
