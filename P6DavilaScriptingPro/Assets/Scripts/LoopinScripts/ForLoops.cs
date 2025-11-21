using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{
   public int numEnermies = 3;
    // Start is called before the first frame update
    void Start()
    {
      for(int i = 1; i <= numEnermies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
