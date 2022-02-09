using System.Linq;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu]
    public class SideChessConfig : ScriptableObject
    {
        [SerializeField] private string _id;
        [SerializeField] private FigureConfig[] _figursSideChess;

        public FigureConfig GetFigureConfig(string id)
        {
            return _figursSideChess.FirstOrDefault(s => s.ID == id);
        }
    }
}