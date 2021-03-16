using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour
{
	public GameObject prefab;
	public int pisos = 10;

    // Start is called before the first frame update
    void Start()
    {
    	float x, y;
    	for (float i = 0; i <= pisos; i++)
    	{
    		x = 1;
    		y = 1;
    		for(float j = 0; j <= 3; j++)
    		{
    			x = x * -1;
    			if (j > 1) 
    			{
    				y = -1;
    			}
    			Instantiate(prefab, new Vector3(0.5f * x, 0.5f + i, 0.5f * y), transform.rotation); 
    		}
    	}    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
