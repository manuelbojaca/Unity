using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retenedor1 : MonoBehaviour
{
	public float num;
	public float alt;
	public GameObject prefab;
	public GameObject destructor;
	private Transform tr;
	private GameObject[] objArr;
    // Start is called before the first frame update
    void Start()
    {
    	objArr = new GameObject[4];
    	num = 1.5f;
    	alt = 10f;
        float x, y;
		x = 1f;
		y = 1f;
		for(float j = 0f; j <= 3f; j++)
		{
			x = x * -1f;
			if (j > 1f) 
			{
				y = -1f;
			}
			objArr[(int)j] = (GameObject)Instantiate(prefab, new Vector3(num * x, alt , num * y), transform.rotation) as GameObject; 
		}
		tr = destructor.GetComponent(typeof(Transform)) as Transform;
	}

    // Update is called once per frame
    void Update()
    {
        if (tr.position.y < 50)
        {
        	for(int i = 0;i<4;i++)
        	{
        		Destroy (objArr[i]);
        	}
        }
    }
}