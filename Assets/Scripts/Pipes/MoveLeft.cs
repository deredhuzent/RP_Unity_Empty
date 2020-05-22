using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private void Update()
    {
        movement();
    }

    private void movement()
    {

        var xPosition = transform.position.x;

        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);

        if(xPosition == -9f){
            Destroy(gameObject);
        }
    }
}
