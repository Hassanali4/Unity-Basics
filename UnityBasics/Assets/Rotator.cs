using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]float _RotationSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, _RotationSpeed);
    }
}
