using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoInimigo1 : MonoBehaviour
{
    public float vel;
    public GameObject player;
    Vector3 diff;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        diff = player.transform.position - transform.position;
        if (diff.magnitude < 10)
        {
            transform.position += diff*vel/(diff.magnitude);
        }
    }
}
