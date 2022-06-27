using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    
    public float hiz;
    public float ziplamaHiz; 
    private Rigidbody2D rb;
    private float hizX; 
    private Vector3 yon; 
    private Animator anim;
    public bool onGround; 
    public TextMeshProUGUI scoreText;
    float score;
    



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        yon = transform.localScale; 
        anim = GetComponent<Animator>();

    }

    void Update()
    {
        
        hizX = Input.GetAxis("Horizontal"); 
        rb.velocity = new Vector2(hizX * hiz, rb.velocity.y);
        anim.SetFloat("Speed", Mathf.Abs(hizX));
        

        if (hizX > 0)
        {
            transform.localScale = new Vector3(yon.x, yon.y, yon.z); 
        }
        if (hizX < 0)
        {
            transform.localScale = new Vector3(-yon.x, yon.y, yon.z); 
        }

        if (Input.GetKeyDown(KeyCode.Space)&& onGround==true) 
        {
            if (onGround && Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetTrigger("jump"); 
                rb.velocity = new Vector2(rb.velocity.x,ziplamaHiz);
                onGround = false;
            }
        }

        

    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        
        
        if (collision.gameObject.tag=="Ground")
        {
            onGround = true;
        }
        
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "altin")
        {

            score++;
            scoreText.text = score.ToString();
            Destroy(collision.gameObject);

        }
    }
   


}

