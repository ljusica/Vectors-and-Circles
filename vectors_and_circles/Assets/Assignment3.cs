using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment3 : ProcessingLite.GP21
{
    public Vector2 circlePosition;
    public float diameter = 2;
    public Vector2 velocity = new Vector2(0, 0);
    private float speed = 0.01f;


    void Start()
    {
        circlePosition.x = Width / 2;
        circlePosition.y = Height / 2;
    }

    void Update()
    {
        Background(0);
        Circle(circlePosition.x, circlePosition.y, diameter);
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = new Vector2(mousePos.x - circlePosition.x, mousePos.y - circlePosition.y);
        circlePosition += velocity;


        if (circlePosition.y > Height || circlePosition.y < 0)
        {
            velocity.y *= -1;
        }

        if (circlePosition.x > Width || circlePosition.x < 0)
        {
            velocity.x *= -1;
        }


        if (Input.GetMouseButton(0))
        {

            velocity.x = speed * direction.x;
            velocity.y = speed * direction.y;
            Line(circlePosition.x, circlePosition.y, mousePos.x, mousePos.y);

        }
    }
}