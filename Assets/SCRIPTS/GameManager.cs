using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private LevelGrid levelGrid;
    private ChessPiece chessPiece;

    private GameAssets gameAssets;

    //tamaño del tablero
    private float minX = 7f;
    private float minY = 7f;
    private float distanceBetween = 1f; //para que queden centrados

    public bool boardIsFull; // será como nuestro game over cuando esten todas las casillas llenas

    public List<Vector2> positionsInScene; //posiciones ocupadas en el tablero
    private Vector3 randomPos;
    private float spawnRate = 2f;
    private void Start()
    {
        //configuaración del sprite
        GameObject chessPieceGameObject = new GameObject("Chess Piece");
        SpriteRenderer chessPieceSpriteRenderer = chessPieceGameObject.AddComponent<SpriteRenderer>();
        chessPieceSpriteRenderer.sprite = GameAssets.Instance.chessPieceSprite;
        chessPiece = chessPieceGameObject.AddComponent<ChessPiece>();

        gameAssets = FindAnyObjectByType<GameAssets>();
        // Configurar el LevelGrid
        //levelGrid = new LevelGrid(7,7);   

    }
    private Vector2 RandomSpawnPosition() //cuantos saltos doy
    {
        float spawnPosX = minX + Random.Range(8, 0) * distanceBetween; //enq columna 
        float spawnPosY = minY + Random.Range(0, 8) * distanceBetween;
        return new Vector2(spawnPosX, spawnPosY);
    }

    private IEnumerator SpawnRandomPos()
    {
        while (!boardIsFull)
        {
            yield return new WaitForSeconds(spawnRate); //tiempo de aparición
            randomPos = RandomSpawnPosition();


        }
    }
}
