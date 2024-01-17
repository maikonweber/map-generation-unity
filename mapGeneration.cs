using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBahaviour {
    public int mapWidth;
    public int mapHeight;
    public float noiseScale;

    public void generateMap() {
        float[,] noiseMap = Noise.GenerateNoiseMap(mapWidth, mapHeight, noiseScale)
    }
}