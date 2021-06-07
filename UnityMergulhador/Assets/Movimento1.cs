using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Movimento1 : MonoBehaviour
{
    public float vel, dist;
    public GameObject player;
    private Rigidbody2D _rigidbody;
    Vector3 diff;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        diff = player.transform.position - transform.position;
        if (diff.magnitude < dist)
        {
            transform.position += diff*vel/(diff.magnitude);
        }
        
        //if (gameObject.transform.position.y <= -2f)
        //{
        //    _rigidbody.gravityScale = 0f;
        //}
        //else {_rigidbody.gravityScale = 1f;}
    }
}
