using UnityEngine;
using System.Collections;
using TestLibrary;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ClassUnderTest c = new ClassUnderTest();
        Debug.Log("Did it!");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
