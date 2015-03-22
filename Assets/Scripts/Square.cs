using UnityEngine;
using System.Collections;

public class Square : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnMouseDown()
    {
        GameObject squ = GameObject.FindGameObjectWithTag("Square");
        transform.SetParent(squ.transform);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
