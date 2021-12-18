using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    [SerializeField] private List<Transform> _parts;
    [SerializeField] private float _partDistance;
    [SerializeField] private GameObject _partsPrefab;

    [Range(0, 4), SerializeField] private float _speed;
    [Range(0, 4), SerializeField] private float lrspeed;



    private void Update()
    {
        MoveHead(_speed);
        MoveHorisontal();
        MoveTail();
    }

    private void MoveHead(float speed)
    {
        transform.position = transform.position + transform.forward * speed * Time.deltaTime;
    }
    
    private void MoveTail()
    {
        float Dist = Mathf.Sqrt(_partDistance);
        Vector3 prevPos = transform.position;

        foreach (var part in _parts)
        {
            if ((part.position - prevPos).sqrMagnitude > Dist)
            {
                Vector3 currentPartPosition = part.position;
                part.position = prevPos;
                prevPos = currentPartPosition;
            }
            else
            {
                break;
            }
        }
    }

    private void MoveHorisontal()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * lrspeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * lrspeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Food")
        {
            Destroy(other.gameObject);
            GameObject part = Instantiate(_partsPrefab);
            _parts.Add(part.transform);
        }
    }

}
