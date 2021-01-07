using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public Rigidbody2D rb2;
    public KeyCode moveUpP2;
    public KeyCode moveDownP2;
    public int speed;
    Vector2 startPos;
    Vector2 endPos;
    string direction;   
    void Update()
    {
        direction=null;
        if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touch_pos = Camera.main.ScreenToWorldPoint(touch.position);
            if(touch_pos.x>0)
            {
                switch(touch.phase)
                {
                    case TouchPhase.Began:
                    startPos = touch_pos;
                    //Debug.Log("Began at "+touch_pos);
                    break;

                    case TouchPhase.Moved:
                    if(startPos.y<endPos.y)
                    direction="MoveUpP2";
                    //Debug.Log("MoveUp");
                    else if(startPos.y>endPos.y)
                    direction="MoveDownP2";
                    //Debug.Log("MoveDown");
                    break;

                    case TouchPhase.Ended:
                    endPos = touch_pos;
                    //Debug.Log("Ended at "+touch_pos);
                    break;
                }
            }
        }
        if(Input.GetKey(moveUpP2) || (direction=="MoveUpP2"))
        {
            rb2.AddForce(new Vector2(0, speed * 1));
            //Debug.Log("MoveUpPlayer");
        }
        else if(Input.GetKey(moveDownP2) || (direction=="MoveDownP2"))
        {
            rb2.AddForce(new Vector2(0, speed * -1));
            //Debug.Log("MoveDownPlayer");
        }
    }
}
