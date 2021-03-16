using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuerza : MonoBehaviour
{
	public float fuerza = 100f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.down * fuerza, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
