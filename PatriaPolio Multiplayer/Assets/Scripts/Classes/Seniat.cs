using UnityEngine;
using System.Collections;

public class Seniat : MonoBehaviour {

	public int senPosition;

	public void Payp (Players player) {
		player.cash -= 	System.Convert.ToInt32(player.cash *0.10);
	}

	public void Payp2 (Players player) {
		player.cash -= 200;
	}


}
