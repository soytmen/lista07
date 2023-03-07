using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act1 : MonoBehaviour
{
    public GameObject cube;
    public int randomZ;
    public int randomX;
    public int randomY;

    void Start()
    {
        for (int i = 0; i<10; i++) 
        { 
        randomY = Random.Range(-5, 5);
        randomX = Random.Range(-5, 5);
        randomZ = Random.Range(-5, 5);
        Vector3 Pos = new Vector3(randomX, randomY, randomZ);
        GameObject Go = Instantiate(cube, Pos, Quaternion.identity);
            Go.transform.localScale = Vector3.one * Random.Range(0,3);

        
        }
    }
    
    void Update()
    {
        
    }
}
