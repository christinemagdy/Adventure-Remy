using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {
    //    private CharacterController controller;
    //    private float speed = 5.0f;
    //    public Vector3 moveVector;
    //    public float verticalVelocity = 0;
    //    public float gravity = 100;
    //    private float animationDuration = 0.0f;
    //    // Use this for initialization
    //    void Start()
    //    {
    //        controller = GetComponent<CharacterController>();
    //    }

    //    // Update is called once per frame
    //    void Update()
    //    {
    //        if (Time.time < animationDuration)
    //        {
    //            controller.Move(Vector3.forward * speed * 2 * Time.deltaTime);
    //            return;
    //        }
    //        moveVector = Vector3.zero;
    //        //moveVector.x = Input.GetAxisRaw("Horizontal");
    //        if (controller.isGrounded)
    //        {
    //            verticalVelocity = 0.5f;
    //        }
    //        else {
    //            verticalVelocity -= gravity * Time.deltaTime;
    //        }
    //        //X is left and right
    //        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
    //        //Y is up and down 
    //        moveVector.y = verticalVelocity;
    //        //Z is forward and backward
    //        moveVector.z = speed;
    //        controller.Move(moveVector * Time.deltaTime);


    //        //controller.Move(Vector3.forward * Time.deltaTime * speed);
    //    }
    //}

    public float speed = 6.0F;
    public float jumpSpeed = 15.0F;
    public float gravity = 20.0F;
    public float rotateSpeed = 7.0F;
    private Vector3 moveDirection = Vector3.zero;


    private Rigidbody rb;

	private int countCoins;
	public Text countCoinsText;

	private int countDiamound;
	public Text countDiamoundText;

	private int countHearts;
	public Text countHeartsText;



    //Use this for initialization


   void Start()
        {
        rb = GetComponent<Rigidbody>();
        

		countCoins = 0;
		countDiamound = 0;
		countHearts = 3;
		SetCoinsCountText ();
		SetDiamoundCountText ();
		SetHeartCountText ();



    }

     // Update is called once per frame
        void Update()
    {
		/*
		if (isDead) {
			return;
		}*/

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

        
    }/*
	private void Death()
	{
		if (countHearts == 0) {
			
		}
	}*/

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

        else if (other.gameObject.CompareTag("Diamonds"))
        {
            other.gameObject.SetActive(false);
            CountDiamonds = CountDiamonds + 1;
            SetCountDiamindsText();

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

   
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Coins"))
		{
			other.gameObject.SetActive(false);
			countCoins = countCoins + 1;
			SetCoinsCountText ();
		}
		else if(other.gameObject.CompareTag("Diamound"))
		{
			other.gameObject.SetActive(false);
			countDiamound = countDiamound + 1;
			SetDiamoundCountText ();
		} 
		else if(other.gameObject.CompareTag("Hearts"))
		{
			other.gameObject.SetActive(false);
			if (countHearts == 3) {
				//countHearts = 3;
				SetHeartCountText ();
			} else {
				countHearts = countHearts + 1;
				SetHeartCountText ();
			}



		} 
	}
	void SetCoinsCountText()
	{
		countCoinsText.text = "Count : " + countCoins.ToString ();
	}
	void SetDiamoundCountText()
	{
		countDiamoundText.text = "Diamound : " + countDiamound.ToString ();
	}
	void SetHeartCountText()
	{
		countHeartsText.text = "Hearts : " + countHearts.ToString ();
	}


	private void OnPlayerHit (ControllerColliderHit hit)
	{
		if (hit.gameObject.tag == "Ground") {
			return;
		} 
		else if(hit.gameObject.tag != "Ground"){
			countHearts = countHearts - 1;
		}
	}

}


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
