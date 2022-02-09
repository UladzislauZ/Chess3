using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private ChessConfig _chessConfig;

        private void Start()
        {
            _chessConfig.Init();
            _chessConfig.Arrangement();
        }
    }
}