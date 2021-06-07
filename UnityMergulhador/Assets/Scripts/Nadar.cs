using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nadar : MonoBehaviour
{
    public float maxOxi = 100;
    public float oxigenio; 
    public float JumpForce = 5f;
    public float viscosidade = 1f;
    private Rigidbody2D _rigidbody;
    void Start()
    {
         _rigidbody = GetComponent<Rigidbody2D>();
         oxigenio = maxOxi;
    }
    void Update()
    {
        if(gameObject.transform.position.y <= -2f)
        {
            oxigenio -= 0.05f;
            _rigidbody.AddForce(new Vector2(0, -viscosidade*(_rigidbody.velocity.y)));
            _rigidbody.gravityScale = 0.4f;
            if(Input.GetButtonDown("Jump")&&_rigidbody.velocity.y<4)
            {
                _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            }
        }
        else{
            _rigidbody.gravityScale = 1f;
            if (oxigenio<maxOxi){
                oxigenio = maxOxi;
            }
        }
    }
    public void AumentarOxi()
        {
            maxOxi += 15;
        }
    public void DiminuirOxi1()
    {
        maxOxi -= 5;
    }

    public void DiminuirOxi2()
    {
        maxOxi -= 10;
    }
}
