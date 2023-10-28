using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private LevelGrid levelGrid;
    private ChessPiece chessPiece;

    private void Start()
    {
        //configuaración del sprite
        GameObject chessPieceGameObject = new GameObject("Chess Piece");
        SpriteRenderer chessPieceSpriteRenderer = chessPieceGameObject.AddComponent<SpriteRenderer>();
        chessPieceSpriteRenderer.sprite = GameAssets.Instance.chessPieceSprite;
        chessPiece = chessPieceGameObject.AddComponent<ChessPiece>();

        // Configurar el LevelGrid
        levelGrid = new LevelGrid(7,7);   

    }


}
