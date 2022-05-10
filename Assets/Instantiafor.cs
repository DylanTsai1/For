using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiafor : MonoBehaviour
{
    public GameObject prefab;
    public int Cubos;
    public int Grados; 

    public void CloneObject()
 
    {
        for(int i= 0; i<Cubos; i++)
        {
            GameObject clon;
            clon= Instantiate(prefab);
            clon.transform.Rotate(0, Grados * i, 0);
            clon.transform.Translate(i, i, 0);
            //Destroy(clon, .5f); 
        }
    }
       
}
