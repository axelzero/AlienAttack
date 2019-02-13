using UnityEngine;
using System.Collections;

public class CompleteCameraController : MonoBehaviour {

	public GameObject player;		//Public variable to store a reference to the player game object
    public GameObject mainCamera;

	private Vector3 offset;			//Private variable to store the offset distance between the player and camera

	// Use this for initialization
	void Start () 
	{
		//Calculate and store the offset value by getting the distance between the player's position and camera's position.
		offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is called after Update each frame
	void LateUpdate () 
	{
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
            mainCamera.transform.position = player.transform.position + offset + new Vector3(0f, 0f, -10f);

        if (mainCamera.transform.position.x > 20f) mainCamera.transform.position = new Vector3(20f, mainCamera.transform.position.y, mainCamera.transform.position.z);

        if (mainCamera.transform.position.x < -20f) mainCamera.transform.position = new Vector3(-20f, mainCamera.transform.position.y, mainCamera.transform.position.z);

        if (mainCamera.transform.position.y > 9f) mainCamera.transform.position = new Vector3(mainCamera.transform.position.x, 9f, mainCamera.transform.position.z);

        if (mainCamera.transform.position.y < 0.25f) mainCamera.transform.position = new Vector3(mainCamera.transform.position.x, 0.25f, mainCamera.transform.position.z);
    }
}
