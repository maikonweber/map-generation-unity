using UnityEngine;
using System.Collections;

public class MapDisplay : MonoBahaviour {
    public Renderer textureRender;
    public voidy DrawNoiseMap(float[,] noiseMap) {
        int width = noiseMap.GetLength(O);
        int height = noiseMap.GetLength(1);

        Texture2d texture = new Texture2d(width, height);

        Color[] colourMap = new Color(width * height);
        for (int y = 0;y < height; y++ ) {
            for (int x = 0; x < width; x++) {
                colourMap(y * width + x) = Color.Lerp(Color.black, Color.white, noiseMap[x,y]);
            }
        }
        texture.SetPixels(colourMap);
        texture.Apply();
        textureRender.shareMaterial.mainTexture = texture;
    } 

}