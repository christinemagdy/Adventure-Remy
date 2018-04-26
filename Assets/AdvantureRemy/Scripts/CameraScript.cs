using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    //    private Transform lookAt;
    //    private Vector3 startOffset;
    //    private Vector3 moveVector;
    //    private float transition = 0.0f;
    //    private float animationDuration = 3.0f;
    //    private Vector3 animationOffset = new Vector3(0, 5, 5);
    //    //    private List<GameObject> activeTiles;

    //    // Use this for initialization
    //    void Start()
    //    {
    //        lookAt = GameObject.FindGameObjectWithTag("Player").transform;
    //        startOffset = transform.position - lookAt.position;

    //        //playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    //        //      activeTiles = new List<GameObject>();
    //        //public void LookAt(Vector3 worldPosition, Vector3 worldUp = Vector3.up);
    //    }

    //    // Update is called once per frame
    //    void Update()
    //    {
    //        // transform.position = lookAt.position + startOffset;
    //        moveVector = lookAt.position + startOffset;
    //        // X value
    //        moveVector.x = 0;
    //        //if (transition > 1.0f)
    //        //{
    //        //    //normal camera movement 
    //        //    transform.position = moveVector;

    //        if (transition > 1.0f)
    //        {
    //            //normal camera movement
    //            transform.position = moveVector;
    //        }
    //        else {

    //            //moveVector = lookAt.position + startOffset;
    //            //moveVector.x = 0;
    //            //transform.position = moveVector;

    //            transform.position = Vector3.Lerp(moveVector + animationOffset, moveVector, transition);
    //            transition += Time.deltaTime * 1 / animationDuration;
    //            transform.LookAt(lookAt.position + Vector3.up);

    //        }
    //    }
    //}

	/*
    private Transform lookAt;
    private Vector3 startOffset;
    private Vector3 moveVector;

    // Use this for initialization
    void Start()
    {
        lookAt = GameObject.FindGameObjectWithTag("Player").transform;
        startOffset = transform.position - lookAt.position;
    }

    // Update is called once per frame
    void Update()
    {
        moveVector = lookAt.position + startOffset;
        // X value
        moveVector.y = 5;
        transform.position = moveVector;
        //transform.position = lookAt.position + startOffset;
    }*/

	private Transform lookAt;
	private Vector3 startOffset;
	private Vector3 moveVector;
	private float transition = 0.0f;
	private float animationDuration = 3.0f;
	private Vector3 animationOffset = new Vector3(0,3,3);


	void Start(){
		lookAt = GameObject.FindGameObjectWithTag ("Player").transform;
		startOffset = transform.position - lookAt.position;
	}

	void Update (){
		transform.position = lookAt.position + startOffset;
		moveVector = lookAt.position + startOffset;
		moveVector.x = 0;

		if (transition > 1.0f) {
			transform.position = moveVector;
		} else {
			transform.position = Vector3.Lerp (moveVector + animationOffset, moveVector, transition);
			transition += Time.deltaTime * 1 / animationDuration;
		}
	}

}
