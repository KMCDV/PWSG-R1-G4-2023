using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityGameEventListener : MonoBehaviour, IGameEventListener
{
    public GameEvent gameEvent;
    public UnityEvent response;

    public void OnEventRaised()
    {
        response?.Invoke();
    }

    private void Start()
    {
       gameEvent.RegisterListener(this);
    }

    private void OnDestroy()
    {
        gameEvent.UnregisterListener(this);
    }
}
