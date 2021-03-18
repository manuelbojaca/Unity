using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class vel : MonoBehaviour
{
	public GameObject body;
	private Rigidbody rb;
	private TMP_Text velocidad;
	private string textSpd;
	private float maxVel;
	private float speed;
	private float impacto;
	private float deltaSpd;
    // Start is called before the first frame update
    void Start()
    {
    	maxVel = 0f;
    	velocidad = GetComponent<TMP_Text>();
        rb = body.GetComponent(typeof(Rigidbody)) as Rigidbody;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
    	//speed = Mathf.RoundToInt(rb.velocity.magnitude * 3600 / 1000);
    	speed = Mathf.RoundToInt(rb.velocity.magnitude);

    	textSpd = speed + "m/s " + maxVel + "m/s " + impacto +"J";
    	velocidad.text = textSpd;
    	if (deltaSpd >= speed) 
    	{
    		if (deltaSpd > maxVel)
    		{
    			maxVel = deltaSpd;
    			impacto = ((rb.mass / 2f) * (maxVel * maxVel));
    		}
    	}
    	deltaSpd = speed;
    }
}
