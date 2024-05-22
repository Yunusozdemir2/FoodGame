using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ManMove : MonoBehaviour
{


    private Rigidbody2D rb;

    public float speed;
    private int score = 0;
    public Text ScoreText;




    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }




    void FixedUpdate()
    {
        Obesse();
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetType() == typeof(BoxCollider2D))
        {
            Destroy(collision.collider.gameObject);
            score++;
            UpdateText();
        }
    }


    private void UpdateText()
    {
        ScoreText.text  = score.ToString();
    }


    private void Obesse()
    {
        if (score <= 25)
        {
            float MoveHorizontalInput = Input.GetAxis("Horizontal");
            Vector3 Movehorizontal = Vector3.right * MoveHorizontalInput * speed * 10 * Time.deltaTime;
            transform.Translate(Movehorizontal);
        }

        if(score > 25)
        {
            float MoveHorizontalInput = Input.GetAxis("Horizontal");
            Vector3 Movehorizontal = Vector3.right * MoveHorizontalInput * speed * 5 * Time.deltaTime;
            transform.Translate(Movehorizontal);
        }
    }
}

