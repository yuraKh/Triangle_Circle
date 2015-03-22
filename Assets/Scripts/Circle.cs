using UnityEngine;
using System.Collections;

public class Circle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnMouseDown()
    {
        GameObject cir = GameObject.FindGameObjectWithTag("Circle");
        transform.SetParent(cir.transform);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
