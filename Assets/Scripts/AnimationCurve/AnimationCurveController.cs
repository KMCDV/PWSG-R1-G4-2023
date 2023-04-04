using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCurveController : MonoBehaviour
{
    [SerializeField] private float speed = 1f; // [] <- Attribute / 1.0f < f do float
    public Vector3 startPoint;
    public Vector3 endPoint;
    public float currentTime;
    public AnimationCurve curve;
    public string text;
    public string textInText = "Text in Text xD";
    // Start is called before the first frame update
    void Start()
    {
        startPoint = transform.position;
        endPoint = Vector3.Scale(startPoint, new Vector3(-1, 1, 1));
        text = $"Text {currentTime}, {endPoint}, {curve}";
        Debug.Log(text);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime * speed;
        transform.position = Vector3.LerpUnclamped(startPoint, endPoint, curve.Evaluate(currentTime));
    }
}
