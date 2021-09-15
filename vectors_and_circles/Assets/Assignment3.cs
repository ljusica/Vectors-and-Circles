using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment3 : ProcessingLite.GP21
{
	public Vector2 circlePosition;
	public float diameter = 2;
	int colorValue = 0;
	public Vector2 velocity = new Vector2(0, 0);


	void Start()
    {
		circlePosition.x = Width / 2;
		circlePosition.y = Height / 2;
	}

    void Update()
	{
		Background(0);
		Circle(circlePosition.x, circlePosition.y, diameter);

		if (Input.GetMouseButton(0))
		{
			//circlePosition.x = MouseX;
			//circlePosition.y = MouseY;

			Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 direction = new Vector2(circlePosition.x - mousePos.x, circlePosition.y - mousePos.y);
			
			Line(circlePosition.x, circlePosition.y, mousePos.x, mousePos.y);
			
			velocity.x = 0.5f * direction.x * -1;
			velocity.y = 0.5f * direction.y * -1;
			

			
			Debug.Log(direction);
			

		}
	}
}