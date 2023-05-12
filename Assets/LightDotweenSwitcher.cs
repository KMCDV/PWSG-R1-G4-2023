using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LightDotweenSwitcher : MonoBehaviour
{
    public void TurnOnTheLight()
    {
        Light light = GetComponent<Light>();
        light.intensity = 0;
        light.DOIntensity(5f, .5f);
    }
}
