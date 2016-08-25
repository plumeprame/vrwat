using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ShowDiglog : MonoBehaviour {
	public int TextBoxOnCheck = 0;
	public GameObject MessageBox;
	public GameObject TextBox1; // Defines the text box as an object
	public GameObject TextBox2; // Defines the text box as an object
	public GameObject TextBox3; // Defines the text box as an object
	public GameObject TextBox4;
	public string dialog1;
	public string dialog2;
	public string dialog3;
	public string dialog4;
	public string[] Dialog;

	string TextMessage1; // The text we can change
	string TextMessage2;
	string TextMessage3;
	string TextMessage4;


	// Use this for initialization
	void Start () {
		MessageBox.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){

		if (TextBoxOnCheck == 0) {
			Debug.Log ("Click Leaw!!");
			TextBoxOnCheck = 1; //Sets the variable to turn the box off
			MessageBox.SetActive(true); //Re-enables the box
			TextMessage1 = dialog1;
			TextMessage2 = dialog2;
			TextMessage3 = dialog3;
			TextMessage4 = dialog4;
			TextBox1.GetComponent<Text>().text = TextMessage1; //changes the message
			TextBox2.GetComponent<Text>().text = TextMessage2; //changes the message
			TextBox3.GetComponent<Text>().text = TextMessage3; //changes the message
			TextBox4.GetComponent<Text>().text = TextMessage4; //changes the message
		}
		else {
			Debug.Log ("close");
			TextBoxOnCheck = 0;
			MessageBox.SetActive(false);

		}
	}
}
