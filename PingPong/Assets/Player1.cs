using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public Rigidbody2D rb1;
    public KeyCode moveUpP1;
    public KeyCode moveDownP1;
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
            if(touch_pos.x<0)
            {
                switch(touch.phase)
                {
                    case TouchPhase.Began:
                    startPos = touch_pos;
                    //Debug.Log("Began at "+touch_pos);
                    break;

                    case TouchPhase.Moved:
                    if(startPos.y<endPos.y)
                    direction="MoveUpP1";
                    else if(startPos.y>endPos.y)
                    direction="MoveDownP1";
                    break;

                    case TouchPhase.Ended:
                    endPos = touch_pos;
                    //Debug.Log("Ended at "+touch_pos);
                    break;
                }
            }
        }
        if(Input.GetKey(moveUpP1) || direction=="MoveUpP1")
        {
            rb1.AddForce(new Vector2(0, speed * 1));
        }
        else if(Input.GetKey(moveDownP1) || direction=="MoveDownP1")
        {
            rb1.AddForce(new Vector2(0, speed * -1));
        }
    }
}
