using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player_movement : MonoBehaviour
{
    public int trigger = 0;
    public Rigidbody2D rb;
    public Gamefunctions logic;
    public SpriteRenderer ball;
    
    void Start()
    {
         logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Gamefunctions>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Wall" || collision.collider.tag == "Bar")
        {
            trigger = 1;
            rb.velocity = Vector2.zero;
        }
        if (collision.collider.tag == "Obstacle")
        {
            this.enabled = false;
            ball.enabled = false;
            logic.gameover();
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider.tag == "Wall" || collision.collider.tag == "Bar") trigger = 1;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Trigger")
        {
            // Debug.Log("fuck you");
            this.enabled = false;
            ball.enabled = false;
            logic.gameover();
        }
        if (other.tag == "Win")
        {
            Debug.Log("yey");
            SceneManager.LoadScene("Winning_Screen");
        }
    }
    void Update()
    {
        if((trigger==1) && (Input.GetKey(KeyCode.A))){
                rb.velocity = Vector2.right*(-25);
        }
        if((trigger==1) && (Input.GetKey(KeyCode.D))){
                rb.velocity = Vector2.right*(25);
        }
    }
}
