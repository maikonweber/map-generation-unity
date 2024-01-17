using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRandomWalkDungeonGenerator : MonoBahaviour 
{
    [SerializeField]
    protected Vector2Int startPosition = Vector2Int.zero;
    [SerializeField]
    private int interation = 10;
    [SerializeField]
    public int walkLength = 10;
    [SerializeField]
    public boo startRandonOnlyEachIteration = true;

    public void RunProceduralGeneration() {
        HashSet<Vector2Int> floorPositions  = RunRandomWalk();
    }

    protected HashSet<Vector2Int> RunRandomWalk()
    {
        var currentPosition = startPosition;
        HashSet<Vector2Int> florPosition = new HashSet<Vector2Int>();
        for(int i = 0; i < interation; i++)
        {
            var path = ProceduralGenerationAlgoritms.SimpleRandomWalk(currentPosition, walkLength);
            floorPositions.UnionWith(path);
            if(startRandomlyEachIteration)
            {
                currentPosition = floorPositions.ElementAt(Random.Range)
            }
        }
        return floorPositions;
    }
}