using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class act2 : MonoBehaviour
{
    public TextMeshProUGUI texto;
    public int contador = 0;
    void Start()
    {
        StartCoroutine(counter());
    }

    public IEnumerator counter()
    {
        while (true) 
    { 
        yield return new WaitForSeconds(1);
            texto.text = $"{contador}";
            contador++;
            
    }
}
    
    void Update()
    {
        
    }
}
