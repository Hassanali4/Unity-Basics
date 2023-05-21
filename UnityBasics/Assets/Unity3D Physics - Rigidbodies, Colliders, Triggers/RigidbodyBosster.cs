using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyBosster : MonoBehaviour
{
    [SerializeField]
    float _ForceAmount = 100f;
    [SerializeField]
    private GameObject _LosePanel;
    [SerializeField]
    private GameObject _InGamePanel;

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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Lose")
        {
            GetComponent<MeshRenderer>().enabled = false;
            rigidbody1.isKinematic = true;
            _LosePanel.gameObject.SetActive(true);
            _InGamePanel.gameObject.SetActive(false);
        }
    }
}
