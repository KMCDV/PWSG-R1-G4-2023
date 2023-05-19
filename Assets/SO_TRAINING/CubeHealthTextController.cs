using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeHealthTextController : MonoBehaviour, INewsletterReceiver
{
    public TextMeshProUGUI textMeshProUGUI;
    public IntValue cubeHp;
    public GameNewsletter playerDeathNewsletter;

    private void Awake()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        playerDeathNewsletter.RegisterForNewsletter(this);
    }

    private void Update()
    {
        UpdateTextWithNumber(cubeHp.value);
    }

    public void UpdateTextWithNumber(int value)
    {
        if(textMeshProUGUI != null)
            textMeshProUGUI.text = value.ToString();
    }

    public void Notify()
    {
        Debug.Log("Player Died, I received a newsletter :)");
    }
}
