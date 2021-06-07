using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    public float vel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
            transform.position += new Vector3 (0,1,0)*vel;
        }
        if(Input.GetKey("a"))
        {
            transform.position += new Vector3 (-1,0,0)*vel;
        }
        if(Input.GetKey("s"))
        {
            transform.position += new Vector3 (0,-1,0)*vel;
        }
        if(Input.GetKey("d"))
        {
            transform.position += new Vector3 (1,0,0)*vel;
        }
    }
}
