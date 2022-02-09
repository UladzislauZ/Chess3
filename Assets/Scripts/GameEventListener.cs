using System;
using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace
{
    public class GameEventListener : MonoBehaviour
    {
        [SerializeField] private GameEvent eventGame;
        [SerializeField] private UnityEvent Response;

        private void OnEnable()
        {
            eventGame.RegisterListener(this);
        }

        private void OnDisable()
        {
            eventGame.UnregisterListener(this);
        }

        public void OnEventRaised()
        {
            Response?.Invoke();
        }
    }
}