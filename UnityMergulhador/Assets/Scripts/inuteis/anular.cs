using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anular : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("Manter").GetComponent<partida>().a = false;
    }
}
