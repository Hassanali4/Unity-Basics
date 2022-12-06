using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalWorldClass : MonoBehaviour
{
    public Vector3 destination;

    Vector3 point;
    Vector3 vector;
    Vector3 direction;

    void Start()
    {
      /*  Debug.Log ("Local Position : " + transform.localPosition);
	    Debug.Log ("Local Rotation : " + transform.localRotation);
	    Debug.Log ("Local Rotation (E) : " + transform.localEulerAngles);
        Debug.Log("Local Scale : " + transform.localScale);

        Debug.Log("Global Postion : " + transform.position);
        Debug.Log("Global Rotaion : " + transform.rotation);
        Debug.Log("Global Roation : " + transform.eulerAngles);

        Debug.Log("Lossy Scale : " + transform.lossyScale + " !!!Read-Only!!!");  */

        point = transform.TransformPoint(destination);
        vector = transform.TransformVector(destination);
        direction = transform.TransformDirection(destination);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(point, 0.2f);
        Gizmos.color = Color.magenta;
        Gizmos.DrawSphere(vector,0.2f);
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(direction, 0.2f);

    }
}
