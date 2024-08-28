using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{ 
    [SerializeField] private float _speed = 100f;

    private readonly Vector3 _direction = new Vector3(0, 1, 0);
    
    void Update()
    {
        transform.Rotate(_direction * (_speed * Time.deltaTime));
    }
}