using UnityEngine;
using System.Collections;

public class BotonsMenu : MonoBehaviour {


	public void BotonPlay() {

		Application.LoadLevel ("StartGame");
	}

	public void BotonExit() {

		Application.Quit ();

	}

}
