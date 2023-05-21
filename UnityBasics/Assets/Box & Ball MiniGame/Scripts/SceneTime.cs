using UnityEngine;
using UnityEngine.UI;

public class SceneTime : MonoBehaviour
{
    [SerializeField] private Text superJumpsText;

    private float startTime;

    private void Start()
    {
        startTime = Time.time;
    }

    private void Update()
    {
        float elapsedTime = Time.time - startTime;
        superJumpsText.text = "Time: " + elapsedTime.ToString("F2");
    }
}
