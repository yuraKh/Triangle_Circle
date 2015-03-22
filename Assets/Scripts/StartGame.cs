using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour
{

    public GameObject[] Figures = new GameObject[14];
    static public GameObject[] FigureMas = new GameObject[Random.Range(5, 20)];
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < FigureMas.Length; i++)
        {
            GameObject FigureGrid = (GameObject)Instantiate(Figures[Random.Range(1, 14)]);
            FigureGrid.transform.position = new Vector3(Random.Range(-85f, 73f), Random.Range(-27f, 32f), FigureGrid.transform.position.z);
            FigureMas[i] = FigureGrid;
        }
    }

    // Update is called once per frame
    void Update()
    {


    }
}