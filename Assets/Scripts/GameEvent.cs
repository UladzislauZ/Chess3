using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu]
    public class GameEvent : ScriptableObject
    {
        private readonly List<GameEventListener> listners = new List<GameEventListener>();

        public void Raise()
        {
            for (int i = 0; i < listners.Count; i++)
            {
                listners[i].OnEventRaised();
            }
        }

        public void RegisterListener(GameEventListener listener)
        {
            listners.Add(listener);
        }

        public void UnregisterListener(GameEventListener listner)
        {
            listners.Remove(listner);
        }
    }
}