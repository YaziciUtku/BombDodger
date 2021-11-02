using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float playerHorizontalSpeed;

    void Update()
    {
        MovePlayer(); 
    }

    private void MovePlayer()
    {
        float h = Input.GetAxisRaw("Horizontal");
        Vector2 currentPosition = transform.position;

        if (h > 0)
        {
            currentPosition.x += playerHorizontalSpeed * Time.deltaTime; // Move Right
        }
        else if(h<0)
        {
            currentPosition.x -= playerHorizontalSpeed * Time.deltaTime; // Move Left
        }

        transform.position = currentPosition;
    }
}
