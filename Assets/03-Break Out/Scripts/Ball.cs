using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //[Header("Set in Inspector")]
    
    
    
    [Header("Set Dynamicaly")]
    public Vector2 ballSpeed;
    


    // Start is called before the first frame update
    void Start()
    {
        ballSpeed = new Vector2(3f, -4f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 deltaPOS = new Vector3(ballSpeed.x, ballSpeed.y, 0f) * Time.deltaTime;
        Vector3 POS = this.transform.position;
        POS = POS + deltaPOS;
        this.transform.position = POS;
        if(transform.position.x < -4.5f)
        {
            Destroy(this.gameObject);
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject GO = collision.gameObject;
        if(GO.CompareTag("Puck") == true || GO.CompareTag("TWall") == true)
        {
            ballSpeed.y = ballSpeed.y * -1;
        }

        if(GO.CompareTag("LWall") == true || GO.CompareTag("RWall") == true)
        {
            ballSpeed.x = ballSpeed.x * -1;
        }
    }
}
