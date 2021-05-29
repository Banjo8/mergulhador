using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oxigenio : MonoBehaviour
{
    public float oxigenio = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        oxigenio -= 0.05f;
    }

   public void AumentarOxi()
    {
        oxigenio += 15;
    }
}
