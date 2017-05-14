using UnityEngine;
using System.Collections;

public class Impuesto : MonoBehaviour {

	public int impPosition;

	public void imp (Players player) {
		player.cash -= 75;
	}
}

