﻿using UnityEngine;

public class RopeCutter : MonoBehaviour
{
   
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToViewportPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null )
            {
                if (hit.collider.tag == "Link")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}