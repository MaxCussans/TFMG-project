using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Noise
{
    public static float[,] GenerateNoiseMap(int MapWidth, int MapHeight, float scale)
    {
        float[,] NoiseMap = new float[MapWidth, MapHeight];

        if(scale <= 0)
        {
            scale = 0.00001f;
        }

        for (int y =0; y < MapHeight; y++)
        {
            for (int x = 0; x < MapWidth; x++)
            {
                float sampleX = x / scale;
                float sampleY = y / scale;

                float perlinValue = Mathf.PerlinNoise(sampleX, sampleY);
                NoiseMap[x,y] = perlinValue;
            }
        }
        return NoiseMap;
    }
}
