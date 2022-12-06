using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyBosster : MonoBehaviour
{
    [SerializeField]
    float _ForceAmount = 100f;

    private Rigidbody rigidbody1;

    private void Awake()
    {
        rigidbody1 = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            rigidbody1.AddForce(Vector3.up * _ForceAmount);
        }
    }
}
