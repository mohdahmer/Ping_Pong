using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControls : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject ball;
    public int Force1;
    public int Force2;
    public Text scoreText;
    public GameObject reStart;

    public void Start()
    {
        scoreText.text=0.ToString();
        i=0;
        Force1 = 60;
        Force2 = 25;
        int rand = Random.Range(0,5);
        if(rand<=2)
        {
            rb.AddForce(new Vector2(Force1 * -1, Force2));
        }
        else
        {
            rb.AddForce(new Vector2(Force1 * 1, Force2));
        }
    }
    int i=0;
     void OnCollisionEnter2D(Collision2D col)
    { 
     if(col.collider.name=="Player1" || col.collider.name=="Player2")
        {
            scoreText.text = (++i*10).ToString();
            //Debug.Log("Collided");
        }

        else 
         if(col.collider.name=="Wall3" || col.collider.name=="Wall4")
        {
            ball.SetActive(false);
            scoreText.text = scoreText.text+"\nGame Over";
            reStart.SetActive(true);
            //Debug.Log("Over");
        }   
    }
}