using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oxigenio : MonoBehaviour
{
    public float oxigenio = 100;
    public float aux;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        aux = oxigenio - 0.05f*Time.time;
    }

   public void AumentarOxi()
    {
        oxigenio += 15;
    }
}