using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombardero : MonoBehaviour
{
	
	public float num;
	public float alt;
	public GameObject prefab;
	private GameObject[] objArr;
    // Start is called before the first frame update
    void Start()
    {
    	objArr = new GameObject[4];
    	
        float x, y;
		
		for(float j = 0f; j < 4f; j++)
		{
			x = 1f;
			y = 0f;
			if (j > 0f) 
			{	
				x = -1f;
				if (j > 1f) 
				{
					x = 0f;
					y = 1f;
					if (j > 2f)
					{
						y = -1f;
					} 
				}
			}	
			objArr[(int)j] = (GameObject)Instantiate(prefab, new Vector3(num * x, alt, num * y), transform.rotation) as GameObject; 
		}
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
        	for(int i = 0;i<4;i++)
        	{
        	
        	}
        }
    }
}
