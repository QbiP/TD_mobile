using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{

    public Texture2D WaveSpawnMap;
    public ColorToEnemy[] colorToEnemy;

    void Start()
    {
        StartCoroutine("WaveSpawning");
    }

    IEnumerator WaveSpawning()
    {
        for(int x = 0; x < WaveSpawnMap.width; x++)
        {
            for(int y =  0; y < WaveSpawnMap.height; y++)
            {
                SpawnEnemy(x, y);
                yield return new WaitForSeconds(0.1f);
            }

        }
    }

    void SpawnEnemy (int x, int y)
    {
        Color pixelcolor = WaveSpawnMap.GetPixel(x, y);
        foreach (ColorToEnemy colorMapping in colorToEnemy)
        {
            if (colorMapping.color.Equals(pixelcolor))
            {
                Instantiate(colorMapping.Enemys[Random.Range(0, colorMapping.Enemys.Length)], this.transform.position, this.transform.rotation);
            }
        }
    }
}
