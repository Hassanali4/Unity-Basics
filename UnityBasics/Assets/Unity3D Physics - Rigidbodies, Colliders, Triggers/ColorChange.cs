using System;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Color randomColorValue = GetRendomColor();
        GetComponent<Renderer>().material.color = randomColorValue;
    }
    private Color GetRendomColor()
    {
        return new Color(
            r: UnityEngine.Random.Range(0f, 1f),
            g: UnityEngine.Random.Range(0f, 1f),
            b: UnityEngine.Random.Range(0f, 1f));
    }
}
