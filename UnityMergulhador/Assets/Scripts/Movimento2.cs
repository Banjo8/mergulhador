using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento2 : MonoBehaviour
{
    public float vel1, vel2, dist1, dist2, cooldown;
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
        if(diff.magnitude < dist1)
        {
            transform.position += diff*vel1/(diff.magnitude);
        }
        if(diff.magnitude < dist1 && cooldown < 15)
        {
            cooldown += 0.05f;
        }
        if(diff.magnitude < dist1 && cooldown > 10)
        {
            transform.position += diff*vel2/(diff.magnitude);
        }
        if(diff.magnitude < dist2 && cooldown > 12)
        {
            cooldown -= 0.1f;
        }
        if (gameObject.transform.position.y <= -2f)
        {
            _rigidbody.gravityScale = 0f;
        }
    }
}
