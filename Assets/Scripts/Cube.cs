using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : MonoBehaviour
{
    public Text amountText;

    public static int amountCube;
    private Color color;
    private SnakeMovement snakeMovement;

    private void Start()
    {
        SetAmount();
        
    }

    

   
    public void SetAmount()
    {
        gameObject.SetActive(true);
        amountCube = Random.Range(1, LevelController.instance.cubesAmount);
        if (amountCube <= 0)
        {
            gameObject.SetActive(false);
        }

        SetAmoungText();
    }

    public void SetAmoungText()
    {
        amountText.text = amountCube.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.TryGetComponent(out SnakeMovement snake)) return;
        if (collision.gameObject.tag == "sn")
        {
            snake.Die();


        }
    }
    
}
