using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu]
    public class ChessConfig : ScriptableObject
    {
        [SerializeField] private SideChessConfig[] _sidesChessConfig;
        [SerializeField] private int _sizeField = 8;
        private Vector3[,] _cagesField;

        public Vector3 GetTransformCage(int idHor, int idVer)
        {
            return _cagesField[idHor, idVer];
        }

        public void Init()
        {
            _cagesField = new Vector3[_sizeField, _sizeField];
            for (int i = 0; i < _sizeField; i++)
            {
                for (int j = 0; j < _sizeField; j++)
                {
                    _cagesField[i,j] = new Vector3(j, 0, i);
                }
            }
        }

        public void Arrangement()
        {
            //black
            Instantiate(_sidesChessConfig[0].GetFigureConfig("Rook1").Prefab, _cagesField[0,0],Quaternion.identity);
            Instantiate(_sidesChessConfig[0].GetFigureConfig("Horse1").Prefab, _cagesField[0,1],Quaternion.identity);
            Instantiate(_sidesChessConfig[0].GetFigureConfig("Elephon1").Prefab, _cagesField[0,2],Quaternion.identity);
            Instantiate(_sidesChessConfig[0].GetFigureConfig("King").Prefab, _cagesField[0,3],Quaternion.identity);
            Instantiate(_sidesChessConfig[0].GetFigureConfig("Queen").Prefab, _cagesField[0,4],Quaternion.identity);
            Instantiate(_sidesChessConfig[0].GetFigureConfig("Elephon2").Prefab, _cagesField[0,5],Quaternion.identity);
            Instantiate(_sidesChessConfig[0].GetFigureConfig("Horse2").Prefab, _cagesField[0,6],Quaternion.identity);
            Instantiate(_sidesChessConfig[0].GetFigureConfig("Rook2").Prefab, _cagesField[0,7],Quaternion.identity);
            Instantiate(_sidesChessConfig[0].GetFigureConfig("Pawn1").Prefab, _cagesField[1,0],Quaternion.identity);
            Instantiate(_sidesChessConfig[0].GetFigureConfig("Pawn2").Prefab, _cagesField[1,1],Quaternion.identity);
            Instantiate(_sidesChessConfig[0].GetFigureConfig("Pawn3").Prefab, _cagesField[1,2],Quaternion.identity);
            Instantiate(_sidesChessConfig[0].GetFigureConfig("Pawn4").Prefab, _cagesField[1,3],Quaternion.identity);
            Instantiate(_sidesChessConfig[0].GetFigureConfig("Pawn5").Prefab, _cagesField[1,4],Quaternion.identity);
            Instantiate(_sidesChessConfig[0].GetFigureConfig("Pawn6").Prefab, _cagesField[1,5],Quaternion.identity);
            Instantiate(_sidesChessConfig[0].GetFigureConfig("Pawn7").Prefab, _cagesField[1,6],Quaternion.identity);
            Instantiate(_sidesChessConfig[0].GetFigureConfig("Pawn8").Prefab, _cagesField[1,7],Quaternion.identity);
            //white
            Instantiate(_sidesChessConfig[1].GetFigureConfig("Rook1").Prefab, _cagesField[7,7],Quaternion.identity);
            Instantiate(_sidesChessConfig[1].GetFigureConfig("Horse1").Prefab, _cagesField[7,6],Quaternion.identity);
            Instantiate(_sidesChessConfig[1].GetFigureConfig("Elephon1").Prefab, _cagesField[7,5],Quaternion.identity);
            Instantiate(_sidesChessConfig[1].GetFigureConfig("King").Prefab, _cagesField[7,4],Quaternion.identity);
            Instantiate(_sidesChessConfig[1].GetFigureConfig("Queen").Prefab, _cagesField[7,3],Quaternion.identity);
            Instantiate(_sidesChessConfig[1].GetFigureConfig("Elephon2").Prefab, _cagesField[7,2],Quaternion.identity);
            Instantiate(_sidesChessConfig[1].GetFigureConfig("Horse2").Prefab, _cagesField[7,1],Quaternion.identity);
            Instantiate(_sidesChessConfig[1].GetFigureConfig("Rook2").Prefab, _cagesField[7,0],Quaternion.identity);
            Instantiate(_sidesChessConfig[1].GetFigureConfig("pawn1").Prefab, _cagesField[6,7],Quaternion.identity);
            Instantiate(_sidesChessConfig[1].GetFigureConfig("pawn2").Prefab, _cagesField[6,6],Quaternion.identity);
            Instantiate(_sidesChessConfig[1].GetFigureConfig("pawn3").Prefab, _cagesField[6,5],Quaternion.identity);
            Instantiate(_sidesChessConfig[1].GetFigureConfig("pawn4").Prefab, _cagesField[6,4],Quaternion.identity);
            Instantiate(_sidesChessConfig[1].GetFigureConfig("pawn5").Prefab, _cagesField[6,3],Quaternion.identity);
            Instantiate(_sidesChessConfig[1].GetFigureConfig("pawn6").Prefab, _cagesField[6,2],Quaternion.identity);
            Instantiate(_sidesChessConfig[1].GetFigureConfig("pawn7").Prefab, _cagesField[6,1],Quaternion.identity);
            Instantiate(_sidesChessConfig[1].GetFigureConfig("pawn8").Prefab, _cagesField[6,0],Quaternion.identity);
        }
    }
}