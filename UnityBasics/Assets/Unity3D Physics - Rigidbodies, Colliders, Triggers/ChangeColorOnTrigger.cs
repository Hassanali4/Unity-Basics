using System;
using UnityEngine;

public class ChangeColorOnTrigger: MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Color randomColorValue = GetRandomColorWithAlpha();
        GetComponent<Renderer>().material.color = randomColorValue;
    }
    private Color GetRandomColorWithAlpha()
    {
        return new Color(
            r: UnityEngine.Random.Range(0f, 1f),
            g: UnityEngine.Random.Range(0f, 1f),
            b: UnityEngine.Random.Range(0f, 1f),
            a:0.25f);
    }
}
