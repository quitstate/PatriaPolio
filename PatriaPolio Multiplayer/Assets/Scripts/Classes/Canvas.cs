using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Canvas : MonoBehaviour {

	public static Canvas canvas;

	void Awake() {
		if (canvas == null) {
			canvas = this;
			DontDestroyOnLoad (gameObject);
		} else if (canvas != this) {
			Destroy (gameObject);	
		}
	}

	void Start() {

		startGame.StartGame.Cashp1t = GameObject.Find("/Canvas/Cashp1t").GetComponent<Text>();
		startGame.StartGame.Cashp2t = GameObject.Find("/Canvas/Cashp2t").GetComponent<Text>();
		startGame.StartGame.Propertiesp1t = GameObject.Find("/Canvas/Propertiesp1t").GetComponent<Text>();
		startGame.StartGame.Propertiesp2t = GameObject.Find("/Canvas/Propertiesp2t").GetComponent<Text>();
	}
}
