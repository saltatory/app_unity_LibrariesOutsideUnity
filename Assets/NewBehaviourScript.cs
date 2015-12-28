using UnityEngine;
using System.Collections;
using TestLibrary;
using Mobilityware.Logging;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ClassUnderTest c = new ClassUnderTest();
        Mobilityware.Logging.Logger.Log("Did it!");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
