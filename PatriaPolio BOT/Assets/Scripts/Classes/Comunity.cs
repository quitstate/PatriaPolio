using UnityEngine;
using System.Collections;

public class Comunity : MonoBehaviour {

	public int comPosition;
	public int randomChest;
	public int cplayeract;
	public Scenes scenes;

	public int getRandomChest()	{
		randomChest = Random.Range (1, 17);
		return randomChest;
	}

	public void ChestCards ()	{

		randomChest = getRandomChest();

		switch (randomChest) {

		case 1:

			scenes = new Scenes ();
			scenes.ScenesChest (randomChest);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.players [cplayeract].transform.position = startGame.StartGame.spaces [0].position;
			startGame.StartGame.logicPlayers [cplayeract].pPosition = 0;
			startGame.StartGame.logicPlayers [cplayeract].cash += 200;
			break;

		case 2:

			scenes = new Scenes ();
			scenes.ScenesChest (randomChest);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.logicPlayers [cplayeract].cash += 200;
			break;

		case 3:

			scenes = new Scenes ();
			scenes.ScenesChest (randomChest);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.logicPlayers [cplayeract].cash -= 50;
			break;

		case 4:

			scenes = new Scenes ();
			scenes.ScenesChest (randomChest);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.logicPlayers [cplayeract].cash += 50;
			break;

		case 5:

			scenes = new Scenes ();
			scenes.ScenesChest (randomChest);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.logicPlayers [cplayeract].CarcelCard = 1;
			break;

		case 6:

			scenes = new Scenes ();
			scenes.ScenesChest (randomChest);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.players [cplayeract].transform.position = startGame.StartGame.spaces [11].position;
			startGame.StartGame.logicPlayers [cplayeract].pPosition = 11;
			startGame.StartGame.checkCase ();
			break;

		case 7:

			scenes = new Scenes ();
			scenes.ScenesChest (randomChest);
			cplayeract = startGame.StartGame.cPlayer;
			if (cplayeract == 0){
				startGame.StartGame.logicPlayers [cplayeract].cash += 50;
				startGame.StartGame.logicPlayers [(cplayeract + 1)].cash -= 50;
			} else {
				startGame.StartGame.logicPlayers [cplayeract].cash += 50;
				startGame.StartGame.logicPlayers [(cplayeract - 1)].cash -= 50;
			}
			break;

		case 8:

			scenes = new Scenes ();
			scenes.ScenesChest (randomChest);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.logicPlayers [cplayeract].cash += 100;
			break;

		case 9:

			scenes = new Scenes ();
			scenes.ScenesChest (randomChest);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.logicPlayers [cplayeract].cash += 20;
			break;

		case 10:

			scenes = new Scenes ();
			scenes.ScenesChest (randomChest);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.logicPlayers [cplayeract].cash += 25;
			break;

		case 11:

			scenes = new Scenes ();
			scenes.ScenesChest (randomChest);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.logicPlayers [cplayeract].cash += 100;
			break;



		case 12:

			scenes = new Scenes ();
			scenes.ScenesChest (randomChest);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.logicPlayers [cplayeract].cash -= 100;
			break;

		case 13:

			scenes = new Scenes ();
			scenes.ScenesChest (randomChest);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.logicPlayers [cplayeract].cash -= 150;
			break;


		case 14:

			scenes = new Scenes ();
			scenes.ScenesChest (randomChest);
			//falta buscar con un for todas las propiedades que tenga el jugador actual con casas y hoteles
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.logicPlayers [cplayeract].cash -= (40 * startGame.StartGame.properties[1].houses);
			startGame.StartGame.logicPlayers [cplayeract].cash -= (115 * startGame.StartGame.properties[1].houses);
			break;

		case 15:

			scenes = new Scenes ();
			scenes.ScenesChest (randomChest);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.logicPlayers [cplayeract].cash += 10;
			break;

		case 16:

			scenes = new Scenes ();
			scenes.ScenesChest (randomChest);
			cplayeract = startGame.StartGame.cPlayer;
			startGame.StartGame.logicPlayers [cplayeract].cash += 100;
			break;
		}
	}
}
