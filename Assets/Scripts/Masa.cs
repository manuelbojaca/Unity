using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Masa : MonoBehaviour
{
	public float x;
	public float y;
	public float z;
	public GameObject prefab;
	private float size;
    // Start is called before the first frame update
    void Start()
    {
    	size = prefab.transform.localScale.x;
        for (int i = 0;i < y;i++)
        {
        	for(int j = 0;j < x;j++)
        	{
        		for(int k = 0;k < z;k++)
        		{
        			Instantiate(prefab, new Vector3(-(x / 2) + size / 2 + size * k, size / 2  + size * i, -(z / 2) + size / 2 + size * j), transform.rotation); 
        		}
        	}
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
