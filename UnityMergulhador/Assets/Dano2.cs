using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dano2 : MonoBehaviour
{
    public GameObject player;
    void OnTriggerEnter2D (Collider2D player)
    {
        player.GetComponent<Nadar>().DiminuirOxi2();
    }
}
