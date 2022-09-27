using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakOutManager : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject prefabBall;
    
    
    [Header("Set Dynamicaly")]
    public GameObject ball;


    // Start is called before the first frame update
    void Start()
    {
        NewBall();
    }

    public void NewBall()
    {
        ball = Instantiate(prefabBall) as GameObject;
        ball.transform.position = Vector3.zero;
    }
    // Update is called once per frame
    void Update()
    {
        //if(ball.transform.position.y < -4.5f)
        //{
        //    Destroy(this.gameObject);
        //    NewBall();
        //}
    }
}
