using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public float speed = 2000.0f;
    public float rotateSpeed = 500f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        //transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        //if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        //}
        //if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        //}
        //if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        //}
        //if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        //}

    }
}
