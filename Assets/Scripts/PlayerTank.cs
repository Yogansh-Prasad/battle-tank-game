using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTank : MonoSingletonGeneric<PlayerTank>
{
    protected override void Awake()
    {
        base.Awake();
        //Custom Logic
    }

    /*private void Update()
    {
        if (Input.touchCount > 0) 
        { 
            Touch touch = Input.GetTouch(0);
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            Debug.Log(touchPos);
            touchPos.y = 0f;
            transform.position = touchPos;

        }
    }*/
}
