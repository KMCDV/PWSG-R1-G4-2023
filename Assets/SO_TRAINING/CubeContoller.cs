using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CubeHealthController
public class CubeContoller : MonoBehaviour
{
    public IntValue cubeHp;
    public GameNewsletter playerDeathNewsletter;
    private void Start()
    {
        cubeHp.value = 100;
    }
    private void OnMouseDown()
    {
        cubeHp.value -= 10;
        if(cubeHp.value < 0)
        {
            playerDeathNewsletter.SendNewsletter();
        }
    }
}
