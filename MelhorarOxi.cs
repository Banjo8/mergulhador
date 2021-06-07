using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelhorarOxi : MonoBehaviour
{
    public GameObject item;
    public GameObject jogador;
    Vector3 distancia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distancia = (transform.position - jogador.transform.position);

        if (distancia.magnitude < 2)
        {
            item.SetActive(false);
            jogador.GetComponent<Oxigenio>().oxigenio = jogador.GetComponent<Oxigenio>().oxigenio*1.5f;

        }
    }
}
