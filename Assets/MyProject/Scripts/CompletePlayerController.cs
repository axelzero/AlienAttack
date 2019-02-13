using UnityEngine;
using System.Collections;
using CnControls;

//Adding this allows us to access members of the UI namespace including Text.
using UnityEngine.UI;

public class CompletePlayerController : MonoBehaviour {

    public GameObject shield;
    private GameObject mShieldEffext;

    public float speed;				//Floating point variable to store the player's movement speed.
	public Text countText;			//Store a reference to the UI Text component which will display the number of pickups collected.
	public Text winText;			//Store a reference to the UI Text component which will display the 'You win' message.

	private Rigidbody2D rb2d;		//Store a reference to the Rigidbody2D component required to use 2D Physics.
	private int count;				//Integer to store the number of pickups collected so far.

	// Use this for initialization
	void Start()
	{
		//Get and store a reference to the Rigidbody2D component so that we can access it.
		rb2d = GetComponent<Rigidbody2D> ();

		//Initialize count to zero.
		count = 0;

		//Initialze winText to a blank string since we haven't won yet at beginning.
		//winText.text = "";

		//Call our SetCountText function which will update the text with the current value for count.
		SetCountText ();
	}

	void FixedUpdate()
	{
		//Store the current horizontal input in the float moveHorizontal.
		float moveHorizontal = CnInputManager.GetAxis ("Horizontal");

		//Store the current vertical input in the float moveVertical.
		float moveVertical = CnInputManager.GetAxis ("Vertical");

		//Use the two store floats to create a new Vector2 variable movement.
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		//Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
		rb2d.AddForce (movement * speed);
        BoarsForPlayer();

    }

	
	void OnTriggerEnter2D(Collider2D other) 
	{
        ////Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        //if (other.gameObject.CompareTag ("PickUp")) 
        //{
        //	//... then set the other object we just collided with to inactive.
        //	other.gameObject.SetActive(false);

        //	//Add one to the current value of our count variable.
        //	count = count + 1;

        //	//Update the currently displayed count by calling the SetCountText function.
        //	//SetCountText ();
        //}

        if (other.gameObject.CompareTag("Enemy"))
        {
 
            mShieldEffext = Instantiate(shield, transform.position, transform.rotation);
            mShieldEffext.transform.parent = transform;
            Destroy(mShieldEffext, 1f);
        }
    }

    void SetCountText()
	{
		//Set the text property of our our countText object to "Count: " followed by the number stored in our count variable.
		//countText.text = "Count: " + count.ToString ();

		//Check if we've collected all 12 pickups. If we have...
		if (count >= 12)
			//... then set the text property of our winText object to "You win!"
			winText.text = "You win!";
	}


    void BoarsForPlayer()
    {

        if (transform.position.x > 27.5f) transform.position = new Vector3(27.5f, transform.position.y, transform.position.z);

        if (transform.position.x < -27.5f) transform.position = new Vector3(-27.5f, transform.position.y, transform.position.z);

        if (transform.position.y > 13.5f) transform.position = new Vector3(transform.position.x, 13.5f, transform.position.z);

        if (transform.position.y < -4.3f) transform.position = new Vector3(transform.position.x, -4.3f, transform.position.z);
    }
}
