using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Invoker : MonoBehaviour
{
    public Timer timer;
    public MessageEvent messageEvent;

	//creates an instance of the event object (MessageEvent)
	private void Awake()
	{
		messageEvent = new MessageEvent();
	}

	//adds a no argument UnityAction delegate as a listener
	public void AddNoArgumentListener(UnityAction action)
	{
		messageEvent.AddListener(action);
	}

	// Start is called before the first frame update
	public void Start()
	{
		//get the timer component
		timer = gameObject.AddComponent<Timer>(); 

		//set duration to 2 sec
		timer.SetDuration(2f); 
		timer.Run();
	}

	// Update is called once per frame
	void Update()
    {
		if (timer.CurrentTime() >= timer.GetDuration())
		{
			Debug.Log(timer.GetDuration());
			messageEvent.Invoke(); // Invoke the event
			timer.Reset();
			timer.SetDuration(2f);
			timer.Run();
		}
	}
}
