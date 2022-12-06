using UnityEngine;

public class TiltSpeed : MonoBehaviour
{
    [SerializeField]
    private float _tiltSpeed = 100f;

    private void Update()
    {
        float horizontal = -Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward, horizontal * Time.deltaTime * _tiltSpeed);
    }

}
