using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanvasP : MonoBehaviour {

	public CanvasP canvasP; 

	void Start() {

		startGame.StartGame.Cashp1t = GameObject.Find("/Canvas/Cashp1t").GetComponent<Text>();
		startGame.StartGame.Cashp2t = GameObject.Find("/Canvas/Cashp2t").GetComponent<Text>();
		startGame.StartGame.Propertiesp1t = GameObject.Find("/Canvas/Propertiesp1t").GetComponent<Text>();
		startGame.StartGame.Propertiesp2t = GameObject.Find("/Canvas/Propertiesp2t").GetComponent<Text>();

	

		startGame.StartGame.Cashp1t1 = GameObject.Find("/CanvasP/Cashp1t").GetComponent<Text>();
		startGame.StartGame.Cashp2t2 = GameObject.Find("/CanvasP/Cashp2t").GetComponent<Text>();
		startGame.StartGame.Propertiesp1t1 = GameObject.Find("/CanvasP/Propertiesp1t").GetComponent<Text>();
		startGame.StartGame.Propertiesp2t2 = GameObject.Find("/CanvasP/Propertiesp2t").GetComponent<Text>();

	}

	public void BotonRefresh () {
	

		startGame.StartGame.Cashp1t1.text = startGame.StartGame.Cashp1t.text;
		startGame.StartGame.Cashp2t2.text = startGame.StartGame.Cashp2t.text;
		startGame.StartGame.Propertiesp1t1.text = startGame.StartGame.Propertiesp1t.text;
		startGame.StartGame.Propertiesp2t2.text = startGame.StartGame.Propertiesp2t.text;

	}

}