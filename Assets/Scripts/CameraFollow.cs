using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Snake;
    public Vector3 RoadToCameraOffset;
    public float Speed;

    private float _xSnake;
    private float _zSnake;
    private float _ySnake;

    void Update()
    {
        if (Snake.transform.position == null) return;

        _xSnake = Snake.transform.position.x + RoadToCameraOffset.x;
        _zSnake = Snake.transform.position.z + RoadToCameraOffset.z;
        _ySnake = Snake.transform.position.y + RoadToCameraOffset.y;

        transform.position = new Vector3(15.30671f, _ySnake, _zSnake);

        
    }
}
