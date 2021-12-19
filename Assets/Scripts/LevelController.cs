using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public static LevelController instance;

    public float gameSpeed = 2;

    public int cubesAmount = 6;
        
    private void Awake()
    {
        instance = this;
    }
}
