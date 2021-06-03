using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chao : MonoBehaviour
{
    public GameObject ChaoOriginal;
    void Start()
    {
        //GameObject CloneChao = Instantiate(ChaoOriginal);
        CreateChao(4);
    }

    void CreateChao(int ChaoNum)
    {
        for (int i = 0; i < ChaoNum; i++){
            GameObject CloneChao = Instantiate(ChaoOriginal, new Vector3(ChaoOriginal.transform.position.x + (i-1f)*7.7f,
            ChaoOriginal.transform.position.y, ChaoOriginal.transform.position.z), ChaoOriginal.transform.rotation);
        }


    }
   
}
