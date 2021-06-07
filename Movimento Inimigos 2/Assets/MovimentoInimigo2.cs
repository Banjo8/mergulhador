using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoInimigo2 : MonoBehaviour
{
    public float vel1, vel2, cooldown;
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
            transform.position += diff*vel1/(diff.magnitude);
        }
        if (diff.magnitude < 10 && cooldown < 15)
        {
            cooldown += 0.01f;
        }
        if (diff.magnitude < 10 && cooldown > 9)
        {
            transform.position += diff*vel2/(diff.magnitude);
        }
        if (diff.magnitude < 5 && cooldown > 9)
        {
            cooldown -= 0.02f;
        }
    }
}
