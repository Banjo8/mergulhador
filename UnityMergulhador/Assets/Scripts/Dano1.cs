using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dano1 : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D player)
    {
        player.GetComponent<Nadar>().DiminuirOxi1();
    }
}
