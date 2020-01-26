using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MVMNT : MonoBehaviour
{

	public Rigidbody rb;
	public float fwdforce;
	public GameObject player;
	

	// Start is called before the first frame update
	void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void rot_rt()
	{
		player.transform.Rotate(Vector3.up *  10f);//* 120f * Time.deltaTime);
	}

	public void rot_lft()
	{
		player.transform.Rotate(-Vector3.up * 10f );//* 120f * Time.deltaTime);
	}

	public void move_fwd()
	{
		Vector3 dir = player.transform.rotation * Vector3.forward;
		rb.AddForce(dir * fwdforce , ForceMode.VelocityChange);
	}

	public void move_bck()
	{
		Vector3 dir = player.transform.rotation * Vector3.back;
		rb.AddForce(dir * fwdforce, ForceMode.VelocityChange);
	}

	public void Stop_Moving()
	{
		rb.velocity = new Vector3(0, 0, 0);
	}







}
