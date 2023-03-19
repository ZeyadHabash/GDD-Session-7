using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball_script : MonoBehaviour
{
    public GameObject Fireb;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 StartPoint = transform.position;
            Vector2 Velocity = new Vector2(5, 0);
            Quaternion rotation = Quaternion.Euler(0, 0, -90);
            GameObject ThisBall = (GameObject)Instantiate(Fireb, StartPoint, rotation);
            ThisBall.GetComponent<Rigidbody2D>().velocity = Velocity;
        }
    }
}
