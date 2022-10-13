using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{

   
    [SerializeField] int totalPoints = 10;
    [SerializeField] float distanceFactor = 1;
    [SerializeField] float amplitud = 4;

    [SerializeField] GameObject prefab;
    [SerializeField] LineRenderer LineRenderer;


    private GameObject[] allPoints; 
    void Start()
    {
        allPoints = new GameObject[totalPoints];
        for(int i = 0; i < totalPoints; i++)
        {
            allPoints[i] = Instantiate(prefab, transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < allPoints.Length; i++)
        {
           
            float x = i * distanceFactor;
            float y = amplitud * Mathf.Sin(x +Time.time);
            allPoints[i].transform.localPosition = new Vector3(x, y, 0);
        }
    }
}
