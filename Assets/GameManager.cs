using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public BallControls ball1;
    public GameObject ball;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject restart;
    public KeyCode space;
    Vector2 originalPosition1;
    Vector2 originalPosition2;
    void Start()
    {
        originalPosition1 = Player1.transform.position;
        originalPosition2 = Player2.transform.position;
        
    }
    void Update()
    {
        if(Input.GetKeyDown(space) || (Input.touchCount>0 && Input.GetTouch(0).tapCount==2))
        {
         //Debug.Log("true");
         ball.SetActive(true);
         ball.transform.position=new Vector2(0,0);
         Player1.transform.position = originalPosition1;
         Player2.transform.position = originalPosition2;
         restart.SetActive(false);
         ball1.Start();
        }
        
    }
}
