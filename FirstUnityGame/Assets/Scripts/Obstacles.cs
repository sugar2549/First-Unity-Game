﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour, IRecycle {

    public Sprite[] sprites;

    public Vector2 colliderOffset = Vector2.zero;

    public void Restart() {

        //choose random sprite from the array and display it
        var renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = sprites[Random.Range(0, sprites.Length)];

        //resize collider to match the current sprite
        var collider = GetComponent<BoxCollider2D>();
        var size = renderer.bounds.size;
        size.y += colliderOffset.y;

        collider.size = size;
        collider.offset = new Vector2(-colliderOffset.x, collider.size.y / 2 - colliderOffset.y);
    }

    public void ShutDown() {


    }
    
   
}
