using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed = 0.1f;
    
    private readonly Vector3 _direction = new Vector3(1, 1, 1);

    void Update()
    {
        transform.localScale += _direction * (_speed * Time.deltaTime);
    }
}
