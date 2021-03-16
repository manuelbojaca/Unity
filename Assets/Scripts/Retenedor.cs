using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retenedor : MonoBehaviour
{
	public float num, alt;
    // Start is called before the first frame update
    void Start()
    {
    	num = 1.5f;
    	alt = 10f;
        float x, y;
		x = 1;
		y = 1;
		for(float j = 0; j <= 3; j++)
		{
			x = x * -1;
			if (j > 1) 
			{
				y = -1;
			}
			Instantiate(prefab, new Vector3(num * x, alt , num * y), transform.rotation); 
		}    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
