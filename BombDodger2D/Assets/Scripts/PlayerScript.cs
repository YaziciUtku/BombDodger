using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float playerHorizontalSpeed;
    private float minX = -2.55f;
    private float maxX = 2.55f;

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

        if(currentPosition.x < minX)
        {
            currentPosition.x = minX;
        }
        if (currentPosition.x > maxX)
        {
            currentPosition.x = maxX;
        }

        transform.position = currentPosition;
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Bomb")
        {
            Time.timeScale = 0f;
        }
    }
}
