using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public int Width = 10;
    public int Height = 20;
    public GameObject TilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                Instantiate(TilePrefab, this.transform);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
