using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listener : MonoBehaviour
{
    private Invoker invoker;
    // Start is called before the first frame update
    void Start()
    {
		//get access to the Invoker class
		invoker = Camera.main.GetComponent<Invoker>(); 

		// Add the method as a listener
		invoker.AddNoArgumentListener(Message);
	}

	private void Message()
	{
		//print the message in console
		Debug.Log("Message!"); 
	}
}
