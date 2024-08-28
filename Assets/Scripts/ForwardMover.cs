using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class ForwardMover : MonoBehaviour
{
    private const float Speed = 1f;
    
    private readonly Vector3 _direction = Vector3.forward;

    private void Update()
    {
        transform.Translate(_direction * (Speed * Time.deltaTime));
    }
}