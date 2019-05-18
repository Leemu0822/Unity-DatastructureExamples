using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
	[SerializeField] private GameObject ball;
	
	// Use this for initialization
	void Start ()
	{
		float[] ballX = new float[5];
		for (int i = 0; i < ballX.Length; i++)
		{
			Instantiate(ball, new Vector3(i, 0, 0), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
