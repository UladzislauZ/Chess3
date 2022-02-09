using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu]
    public class FigureConfig : ScriptableObject
    {
        [SerializeField] private string _id;
        [SerializeField] private TypeFigure _typeFigure;
        [SerializeField] private GameObject _prefab;

        public string ID => _id;

        public GameObject Prefab => _prefab;

        public TypeFigure TypeFigure => _typeFigure;
    }
}