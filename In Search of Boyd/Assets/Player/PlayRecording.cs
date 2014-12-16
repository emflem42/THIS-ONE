using UnityEngine;
using System.Collections;

public class PlayRecording : MonoBehaviour {

	/* !!!!!!!!!!!!!!!!!---------IMPORTANT---------!!!!!!!!!!!!!!!!!!!!
	 * --------------------------------------------------------------
	 * This script does not work yet.
	 * --------------------------------------------------------------
	 * */

	public RecordingInfo recorder;
	public GameObject recorderObject;
	public GameObject ghostObject;
	public Ghost ghostScript;
	public bool isActive = false;
	public string recordingNumber;
	string[] recording;
	int counter = 0;
	float timer = 0.0f;


	// Use this for initialization
	void Start () {
		recorder = recorderObject.GetComponent<RecordingInfo> ();
		ghostScript = ghostObject.GetComponent<Ghost> ();
		SetRecording ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isActive)
		{
			timer += Time.deltaTime;
			if (timer >= 0.2f)
			{
				if(recording[counter] != null)
				{
					ghostScript.Move(recording[counter]);
					timer = 0.0f;
					counter++;
				}

				else
				{
					ghostObject.transform.position = ghostScript.initialPosition;
					ghostScript.currentPosition = ghostScript.initialPosition;
					ghostScript.nextPosition = ghostScript.initialPosition;
					timer = 0.0f;
					counter = 0;
					isActive = false;
					ghostScript.isPlaying = false;
				}
			}

		}


		
	}

	void SetRecording()
	{
		switch (recordingNumber) 
		{
				case "recording 1":
						recording = recorder.recording1;
						break;
				case "recording 2":
						recording = recorder.recording2;
						break;
				case "recording 3":
						recording = recorder.recording3;
						break;
				default:
						Debug.Log ("Invalid recording number");
						break;
		}
	}

	void OnMouseDown()
	{
		isActive = true;
		ghostScript.isPlaying = true;
	}
}
