using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partida : MonoBehaviour
{
    public bool a = true;
    void Start()
    {
        if(a){
        GameObject.Find("jonas").transform.position = new Vector3 (21.26f,-1.38f,0f);}
        else{a=true;}
    }
}
