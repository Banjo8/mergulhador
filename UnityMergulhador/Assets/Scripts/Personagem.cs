using UnityEngine;
using System;

public class Personagem : MonoBehaviour
{
    public float MovementSpeed = 1f;
    public float JumpForce = 1f;
    private Rigidbody2D _rigidbody;
    void Start()
    {
         _rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        var movimento = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movimento, 0, 0) * Time.deltaTime * MovementSpeed;
        if(Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y)<0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

        if(Input.GetKey(KeyCode.Z) && gameObject.transform.position.y <= 0)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce/50*(-gameObject.transform.position.y)), ForceMode2D.Impulse);
            print("foi");
        }

        if(gameObject.transform.position.y <= 0)
        {
            _rigidbody.gravityScale = 1 + (gameObject.transform.position.y)/Math.Abs(-1 + gameObject.transform.position.y);
        }
    }
}
