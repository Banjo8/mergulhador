using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentarOxigenio : MonoBehaviour
{
    public GameObject jogador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D jogador)
    {
        jogador.GetComponent<Oxigenio>().AumentarOxi();
        Destroy(gameObject);
    }
}
