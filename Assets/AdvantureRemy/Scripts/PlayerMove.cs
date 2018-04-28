using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {
    public float speed = 10.0f;
    public float jumpSpeed = 15.0F;
	public float moveSpeed;
    public float gravity = 20.0F;
    public float rotateSpeed = 7.0F;
    private Vector3 moveDirection = Vector3.zero;
	public bool isDead = false;


    //private Rigidbody rb;

	private int countCoins;
	public Text countCoinsText;

	public int countHearts=3 ;
	public Text countHeartsText;



    //Use this for initialization


   void Start()
        {
       // rb = GetComponent<Rigidbody>();
        

		countCoins = 0;
		SetCoinsCountText ();
		SetHeartCountText ();
    }

     // Update is called once per frame
        void Update(){
		
		if (isDead) {
			return;
		}

		transform.Translate (Input.GetAxis ("Horizontal") * Time.deltaTime * moveSpeed , 0 , 1*speed);

        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

       // Rotate Player
            transform.Rotate(0, Input.GetAxis("Horizontal"), 0);

        
    }

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag ("Coins")) {
			other.gameObject.SetActive (false);
			countCoins = countCoins + 1;
			SetCoinsCountText ();
		} 
		 if (other.gameObject.CompareTag ("Hearts"))
		{
			other.gameObject.SetActive (false);
			SetHeartCountText ();

			if (countHearts == 3)
			{
				//countHearts = 3;
				SetHeartCountText ();
			} 
			else if (countHearts < 3)
			{
				countHearts = countHearts + 1;
				SetHeartCountText ();
			}
		} 
		 if (other.gameObject.CompareTag ("Barrel")) {
			other.gameObject.SetActive (true);
			countHearts = countHearts - 1;
			SetHeartCountText ();
			if (countHearts == 0)
			{
				Time.timeScale = 0;
				Death ();
				//GameOver.gameObject.SetActive(true);
			}
		}
	}
	void SetCoinsCountText(){
			countCoinsText.text = "Count : " + countCoins.ToString ();
	}
	void SetHeartCountText(){
			countHeartsText.text = "Hearts : " + countHearts.ToString ();
	}

	/*
	void OnPlayerHit (Collision hit){
		if (hit.gameObject.tag == "Ground") {
					return;
		} 
		if(hit.gameObject.tag == "Barrel"){
			
			countHearts = countHearts - 1;
			SetHeartCountText ();
			if (countHearts == 0)
			{

				Time.timeScale = 0;
				//GameOver.gameObject.SetActive(true);
			}
		}
	}*/
	private void Death()
	{
		if (countHearts == 0) {
			//Debug.Log ("Deth");
			isDead = true;

		}


		//GetComponent<Score> ().OnDeath ();
	}
}


/*
			
			private void Death()
			{
				if (countHearts == 0) {
					
				}
			}
*/
    //__________________________________________________________________

  /*  void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            other.gameObject.SetActive(false);
            CountCoins = CountCoins + 1;
            SetCountCoinsText();

          
        }
       

        else if (other.gameObject.CompareTag("Hearts"))
        {
            

            other.gameObject.SetActive(false);

            if (CountHearts < 3)
            {
                CountHearts = CountHearts + 1;
                SetCountHeartsText();
            }
            else
            {
                CountHearts = 3;
                SetCountHeartsText();
            }

            
        }

       

        else if (other.gameObject.CompareTag("Barriers"))
        {
            other.gameObject.SetActive(true);
            CountHearts = CountHearts - 1;
            SetCountHeartsText();

			if (CountHearts == 0)
            {
                
                Time.timeScale = 0;
                GameOver.gameObject.SetActive(true);
            }
        }


    }
    

    void SetCountCoinsText()
    {
        Coins.text = " Coins : " + CountCoins.ToString();
    }

    void SetCountHeartsText()
    {
        Hearts.text = " Hearts : " + CountHearts.ToString();

    }
    void SetCountDiamindsText()
    {
        Diamonds.text = "Diamonds : " + CountDiamonds.ToString();

    }*/

   




//    private CharacterController controller;
//    private float speed = 5.0f;
//    private Vector3 moveVector;
//    private float verticalVelocity = 0;
//    private float gravity = 12;


//    // Use this for initialization

//    void Start()
//    {
//        controller = GetComponent<CharacterController>();

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        moveVector.y = Input.GetAxisRaw("Horizontal");
//        moveVector = Vector3.zero;
//        if (controller.isGrounded)
//        {
//            verticalVelocity = 0.5f;
//        }
//        else
//        {
//            verticalVelocity -= gravity * Time.deltaTime;
//        }
//        //X is left and right
//        moveVector.z = Input.GetAxisRaw("Horizontal") * speed;

//        //Y is up and down
//        moveVector.y = verticalVelocity;

//        //Z is forward and backward
//        moveVector.x = speed;

//        controller.Move(moveVector * Time.deltaTime);

//    }
//}
