using UnityEngine;
using System.Collections;

public class Triangle : MonoBehaviour
{

    void Start()
    {

    }


    void OnMouseDown()
    {
        GameObject tri = GameObject.FindGameObjectWithTag("Triangle");
        transform.SetParent(tri.transform);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}