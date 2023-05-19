using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameNewsletter : ScriptableObject
{
    List<INewsletterReceiver> receivers = new List<INewsletterReceiver>();

    public void SendNewsletter()
    {
        for (int i = 0; i < receivers.Count; i++)
        {
            receivers[i].Notify();
        }
    }

    public void RegisterForNewsletter(INewsletterReceiver newReceiver)
    {
        receivers.Add(newReceiver);
    }

    public void UnsubscribeFromNewsletter(INewsletterReceiver receiverToRemove)
    {
        receivers.Remove(receiverToRemove);
    }
}
