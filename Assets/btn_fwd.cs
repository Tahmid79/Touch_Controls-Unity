using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class btn_fwd : MonoBehaviour
{
	 MVMNT movement;
	 public Button fwd_btn;
	 Rigidbody rb;

	 bool pointerDown;




	// Start is called before the first frame update
	void Start()
    {
		pointerDown = false;
		rb = GetComponent<Rigidbody>();
		movement = GetComponent<MVMNT>();
		//fwd_btn.onClick.AddListener(forward);

	}

    // Update is called once per frame
    void Update()
    {

		if (pointerDown)
		{

			forward();
			

		
		}else if (!pointerDown)
		{
			Stop();
		}
		
	}




	void forward()
	{
		movement.move_fwd();
	}
	void Stop()
	{
		movement.Stop_Moving();
	}


	public void OnPointerDown(PointerEventData eventData)
	{
		pointerDown = true;
		Debug.Log("OnPointerDown");
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		pointerDown = false;
		Debug.Log("OnPointerUP");
	}



}
