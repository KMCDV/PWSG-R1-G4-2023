using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Super Giera/Events/New Game Event", fileName = "New Game Event")]
public class GameEvent : ScriptableObject
{

    public List<IGameEventListener> gameEventListeners = new List<IGameEventListener>();

    public void Raise()
    {
        for (int i = 0; i < gameEventListeners.Count; i++)
        {
            gameEventListeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(IGameEventListener gameEventListener)
    {
        if (gameEventListeners.Contains(gameEventListener))
            return;
        gameEventListeners.Add(gameEventListener);
    }

    public void UnregisterListener(IGameEventListener gameEventListener)
    {
        if (gameEventListeners.Contains(gameEventListener) == false)
            return;
        gameEventListeners.Remove(gameEventListener);
    }

}
