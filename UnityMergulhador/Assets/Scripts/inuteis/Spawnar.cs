using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnar : MonoBehaviour
{
    public bool voltou = false;
    public GameObject alvo;
    void Start()
    {
        if (voltou){
            alvo.transform.position = new Vector3 (21.26f,-1.38f,0f);
            voltou = false;
        }
    }
}
