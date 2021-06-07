using UnityEngine;
using System;

public class Personagem : MonoBehaviour
{
    public float MovementSpeed = 1f;
    public float JumpForce = 1f;
    public Animator animator;
    private Rigidbody2D _rigidbody;
    public bool NoMar = false;
    private bool olhandoDireita = true; private float direcao;
    void Start()
    {
         _rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {

        //Virar
        direcao = Input.GetAxisRaw("Horizontal");
        var movimento = Input.GetAxis("Horizontal");
        if ((direcao<0 && olhandoDireita) || (direcao>0 && !olhandoDireita)){
            olhandoDireita=!olhandoDireita;
            transform.Rotate(0f,180f,0f);
        }
        //Andar
        transform.position += new Vector3(movimento*2, 0, 0) * Time.deltaTime * MovementSpeed;
        //Alterar gravidade
        if (NoMar){
            _rigidbody.gravityScale = 0.5f;
        }
        //Animacao pulo
        animator.SetFloat("velocidade", Mathf.Abs(direcao));
        if(_rigidbody.velocity.y>0.001f || _rigidbody.velocity.y<-0.001f){
            animator.SetFloat("velocidade", 0);
        }
        //Pulo
        if(Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y)<0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

        if(Input.GetKey(KeyCode.LeftShift) && gameObject.transform.position.y <= -10f)
        {
            //_rigidbody.AddForce(new Vector2(0, JumpForce/50*(-gameObject.transform.position.y)), ForceMode2D.Impulse);
            gameObject.transform.position = new Vector3 (2.53f,-0.63f,-0.1f);
        }

        //if(gameObject.transform.position.y <= -10f)
        //{
        //    _rigidbody.gravityScale = 1 + (gameObject.transform.position.y)/Math.Abs(-1 + gameObject.transform.position.y);
        //}
    }
}
