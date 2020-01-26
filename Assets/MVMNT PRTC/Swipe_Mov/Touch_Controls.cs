using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_Controls : MonoBehaviour
{

	MVMNT movement;
	public Vector2 startPos;
	public Vector2 direction;



	void Start()
	{
		movement = GetComponent<MVMNT>();
	}

	void Update()
	{
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			Vector3 touch_pos = Camera.main.ScreenToWorldPoint(touch.position);

			switch (touch.phase)
			{
				//When a touch has first been detected, change the message and record the starting position
				case TouchPhase.Began:
					// Record initial touch position.
					startPos = touch.position;

					break;

				//Determine if the touch is a moving touch
				case TouchPhase.Moved:
					// Determine direction by comparing the current touch position with the initial one
					direction = touch.position - startPos;

					if(direction.x > 0)
					{
						startPos.x = touch.position.x - 0.5f;
					}

					if(direction.x < 0)
					{
						startPos.x = touch.position.x + 0.5f;
					}

					dir_det();
					
					break;

				case TouchPhase.Ended:
					// Report that the touch has ended when it ends	
					
					/*
					while (tmr <= 2)
					{
						tmr += Time.deltaTime;
						dir_det();
					}
					*/

					break;

			}	

		}


		void dir_det()
		{

			if (direction.x > 0)
			{			
					movement.rot_rt();			
			}

			if (direction.x < 0)
			{
					movement.rot_lft();				
			}
		}


	}
}
