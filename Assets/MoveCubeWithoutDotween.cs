using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubeWithoutDotween : MonoBehaviour
{

    private Vector3 originalPosition;
    private float time;
    public AnimationCurve curve;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        
        transform.position = Vector3.LerpUnclamped(originalPosition, originalPosition + Vector3.up * 10, curve.Evaluate(time));
    }
}
