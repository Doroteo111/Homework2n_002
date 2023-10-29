using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessPiece : MonoBehaviour
{
    private Vector2Int gridPosition; //posicion pieza 2d
    private Vector2Int startGridPosition; //punto referencia para mi

    private float horizontalInput, verticalInput;

    //private float gridMoveTimer;          //reminder variables para el tiempo x segundos
    //private float gridMoveTimerMax = 1f;

    private LevelGrid levelGrid;
    private void Awake()
    {
        /*startGridPosition = new Vector2Int(1, 1); //posiciones impares (1-3-5-7)
        gridPosition = startGridPosition;*/

        //crear lista vacia + array de posiciones
    }

    /*public void Setup(LevelGrid levelGrid)
    {
        this.levelGrid = levelGrid;
    }*/
}
