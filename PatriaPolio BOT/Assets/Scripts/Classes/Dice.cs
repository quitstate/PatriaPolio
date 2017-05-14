using UnityEngine;
using System.Collections;

public class Dice : MonoBehaviour {

	public int rollDice(){

		startGame.StartGame.randomNumber = Random.Range (1, 12);
		startGame.StartGame.dicenumber = startGame.StartGame.randomNumber;
		return startGame.StartGame.dicenumber;
	}

}
