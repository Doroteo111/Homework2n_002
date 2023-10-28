using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGrid : MonoBehaviour
{
    private Vector2Int pieceGridPosition;
    private GameObject pieceGameObject;

    private int width;
    private int height;

    private ChessPiece chessPiece;

    public LevelGrid(int w, int h)
    {
        width = w;
        height = h;
    }
    public void Setup(ChessPiece chessPiece)
    {
        this.chessPiece = chessPiece;
        
    }
}
