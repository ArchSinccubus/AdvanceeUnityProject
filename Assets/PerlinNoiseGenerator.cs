using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNoiseGenerator : MonoBehaviour
{
    public int width;
    public int height;

    public float scale;

    public MeshRenderer MR;

    public Texture mainTex;

    // Start is called before the first frame update
    void Start()
    {
        MR.material.mainTexture = generateTexture();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Texture2D generateTexture()
    {
        Texture2D perlinTex = new Texture2D(width, height);

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Color color = Color.Lerp(Color.blue, Color.yellow, CalculateColor(i, j));

                perlinTex.SetPixel(i, j, color);
            }
        }
        perlinTex.Apply();
        return perlinTex;
    }

    private float CalculateColor(int x, int y)
    {
        float xCoord = (float)x / width * scale;
        float yCoord = (float)y / height * scale;


        return Mathf.PerlinNoise(xCoord, yCoord);
    }
}
