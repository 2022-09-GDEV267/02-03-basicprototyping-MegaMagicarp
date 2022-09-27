using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject prefabBall;
    
    
    [Header("Set Dynamicaly")]
    public float ballSpeed;
    public GameObject ball;


    // Start is called before the first frame update
    void Start()
    {
        ballSpeed = 3f;
        ball = Instantiate(prefabBall) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
