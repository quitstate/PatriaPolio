using UnityEngine;
using System.Collections;

public class Chance : MonoBehaviour {

	public int chancePosition;
	public int randomChance;
	public int cplayeract;
	public Scenes scenes;

	public int getRandomChance()	{
		randomChance = Random.Range (1, 17);
		return randomChance;
	}

	public void ChanceCards ()	{

		randomChance = getRandomChance();
		switch (randomChance) {

		case 1:

			scenes = new Scenes ();
			scenes.ScenesChance (randomChance);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.players [cplayeract].transform.position = startGame.StartGame.spaces [0].position;
			startGame.StartGame.logicPlayers [cplayeract].pPosition = 0;
			startGame.StartGame.logicPlayers [cplayeract].cash += 200;
			break;

		case 2:

			scenes = new Scenes ();
			scenes.ScenesChance (randomChance);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.players [cplayeract].transform.position = startGame.StartGame.spaces [24].position;
			startGame.StartGame.logicPlayers [cplayeract].pPosition = 24;
			startGame.StartGame.checkCase ();
			break;	
		
		case 3:

			scenes = new Scenes ();
			scenes.ScenesChance (randomChance);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.players [cplayeract].transform.position = startGame.StartGame.spaces [12].position;
			startGame.StartGame.logicPlayers [cplayeract].pPosition = 12;
			startGame.StartGame.checkCase ();
			break;	

		case 4:

			scenes = new Scenes ();
			scenes.ScenesChance (randomChance);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.players [cplayeract].transform.position = startGame.StartGame.spaces [35].position;
			startGame.StartGame.logicPlayers [cplayeract].pPosition = 35;
			startGame.StartGame.checkCase ();
			break;	

		case 5:

			scenes = new Scenes ();
			scenes.ScenesChance (randomChance);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.players [cplayeract].transform.position = startGame.StartGame.spaces [25].position;
			startGame.StartGame.logicPlayers [cplayeract].pPosition = 25;
			startGame.StartGame.checkCase ();
			break;

		case 6:

			scenes = new Scenes ();
			scenes.ScenesChance (randomChance);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.players [cplayeract].transform.position = startGame.StartGame.spaces [11].position;
			startGame.StartGame.logicPlayers [cplayeract].pPosition = 11;
			startGame.StartGame.checkCase ();
			break;

		case 7:

			scenes = new Scenes ();
			scenes.ScenesChance (randomChance);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.logicPlayers [cplayeract].cash += 50;
			break;

		case 8:

			scenes = new Scenes ();
			scenes.ScenesChance (randomChance);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.logicPlayers [cplayeract].CarcelCard = 1;
			break;

		case 9:

			scenes = new Scenes ();
			scenes.ScenesChance (randomChance);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.logicPlayers [cplayeract].pPosition -= 3;
			startGame.StartGame.players[cplayeract].transform.position = startGame.StartGame.spaces [startGame.StartGame.logicPlayers[cplayeract].pPosition].position;
			startGame.StartGame.checkCase ();
			break;

		case 10:

			scenes = new Scenes ();
			scenes.ScenesChance (randomChance);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.players [cplayeract].transform.position = startGame.StartGame.spaces [30].position;
			startGame.StartGame.logicPlayers [cplayeract].pPosition = 30;
			startGame.StartGame.checkCase ();
			break;	

		case 11:

			scenes = new Scenes ();
			scenes.ScenesChance (randomChance);
			//falta buscar con un for todas las propiedades que tenga el jugador actual con casas y hoteles
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.logicPlayers [cplayeract].cash += (25 * startGame.StartGame.properties[1].houses);
			startGame.StartGame.logicPlayers [cplayeract].cash += (100 * startGame.StartGame.properties[1].houses);
			break;
		
		case 12:
			
			scenes = new Scenes ();
			scenes.ScenesChance (randomChance);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.logicPlayers [cplayeract].cash -= 15;
			break;

		case 13:

			scenes = new Scenes ();
			scenes.ScenesChance (randomChance);
			cplayeract = startGame.StartGame.cPlayer;
			if (startGame.StartGame.logicPlayers [cplayeract].pPosition > 5) {
				startGame.StartGame.logicPlayers [cplayeract].cash += 200;
			}
			startGame.StartGame.players [cplayeract].transform.position = startGame.StartGame.spaces [5].position;
			startGame.StartGame.logicPlayers [cplayeract].pPosition = 5;
			startGame.StartGame.checkCase ();
			break;	
		
		case 14:

			scenes = new Scenes ();
			scenes.ScenesChance (randomChance);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.players [cplayeract].transform.position = startGame.StartGame.spaces [39].position;
			startGame.StartGame.logicPlayers [cplayeract].pPosition = 39;
			startGame.StartGame.checkCase ();
			break;

		case 15:

			scenes = new Scenes ();
			scenes.ScenesChance (randomChance);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.logicPlayers [cplayeract].cash -= 50;
			break;
		
		case 16:

			scenes = new Scenes ();
			scenes.ScenesChance (randomChance);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.logicPlayers [cplayeract].cash += 150;
			break;
		}
	}
}

