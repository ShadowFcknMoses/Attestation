using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelNumberText : MonoBehaviour
{
    public Text Text;
    

    private void Start()
    {
        Text.text = "Level 1".ToString();
    }
}
