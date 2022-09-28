using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakOutManager : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject prefabBall;
    public GameObject[] levels;
    public Vector3 levelPos;
    
    [Header("Set Dynamicaly")]
    public GameObject ball;
    public GameObject level;
    public int spot;


    // Start is called before the first frame update
    void Start()
    {
        spot = 0;
        StartLevel();
        NewBall();
    }

    public void StartLevel()
    {
        level = Instantiate<GameObject>(levels[spot]);

        level.transform.position = levelPos;
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
