﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class startGame : MonoBehaviour {

	public Property propertiesall;
	public Chance Chance;
	public Comunity Comunity;
	public static startGame StartGame;
	public Text dice,turn,info,Cashp1t, Cashp2t, Propertiesp1t, Propertiesp2t, Cashp1t1, Cashp2t2, Propertiesp1t1, Propertiesp2t2, Loser;
	public int currentPlayer;
	public GameObject[] players;
	public Players[] logicPlayers;
	public GameObject p1;
	public GameObject p2;
	public Transform[] spaces;
	public Property[] properties;
	public Trains[] trains;
	public Services[] services;
	public Comunity[] comunity;
	public Chance[] chance;
	public Jail jail;
	public Freeplaces[] freeplaces;
	public int randomNumber;
	public Seniat seniat;
	public Impuesto impuesto;
	public Scenes scenes;
	public int pos;
	public int cPlayer;
	public int trainnum;
	public int sernum;
	public int dicenumber;
	public int playeract;
	public Dice Dice;

	 void Awake (){
		if (StartGame == null) {
			StartGame = this;
			DontDestroyOnLoad (gameObject);
		} else if (StartGame != this) {
			Destroy (gameObject);	
		}
	}


	void Start () {
		players = new GameObject[]{ p1, p2};
		logicPlayers = new Players[]{ p1.GetComponent<Players> (), p2.GetComponent<Players> ()};
		currentPlayer = 0;	
		spaces = GameObject.Find ("Spaces").GetComponentsInChildren<Transform> ();
		properties = GameObject.Find ("Spaces").GetComponentsInChildren<Property> ();
		trains = GameObject.Find ("Spaces").GetComponentsInChildren<Trains> ();
		services = GameObject.Find ("Spaces").GetComponentsInChildren<Services> ();
		chance = GameObject.Find ("Spaces/").GetComponentsInChildren<Chance> ();
		comunity = GameObject.Find ("Spaces/").GetComponentsInChildren<Comunity> ();
		freeplaces = GameObject.Find ("Spaces/").GetComponentsInChildren<Freeplaces> ();
		seniat = GameObject.Find ("Spaces/").GetComponentInChildren<Seniat> ();
		impuesto = GameObject.Find ("Spaces/").GetComponentInChildren<Impuesto> ();
		jail = GameObject.Find ("Spaces/").GetComponentInChildren<Jail> ();
		scenes = new Scenes ();
		Dice = new Dice ();
		dice = GameObject.Find("/Canvas/Dice").GetComponent<Text>();
		turn = GameObject.Find("/Canvas/Turn").GetComponent<Text>();
		info = GameObject.Find("/Canvas/Info").GetComponent<Text>();
		StartCoroutine(Game());
    }

	IEnumerator Game() {


		int turnmax = 100;
		info.text = "Game will Start";
		yield return new WaitForSeconds(1f);
		Time.timeScale = 0;
		while (turnmax > 0) {
			while (currentPlayer < 2) {
				yield return new WaitForSeconds(1f);
				Time.timeScale = 0;
				movePlayer ();
				checkCase ();
				playeract = currentPlayer;
				dice.text = randomNumber.ToString();
				Cashp1t.text = logicPlayers[0].cash.ToString();
				Cashp2t.text = logicPlayers[1].cash.ToString();
				for (int p = 0; p < properties.Length; p++) {
					for (int i = 0; i < trains.Length; i++) {
						for (int s = 0; s < services.Length; s++) {
							if (logicPlayers [0] ==	trains [i].owner) {
								Propertiesp1t.text = trains [i].name;
							} else if (logicPlayers [0] ==	properties [p].owner) {
								Propertiesp1t.text = properties [p].name;
							} else if (logicPlayers [0] ==	services [s].owner) {
								Propertiesp1t.text = services [s].name;
							}

							if (logicPlayers [1] ==	trains [i].owner) {
								Propertiesp2t.text = trains [i].name;
							} else if (logicPlayers [1] ==	properties [p].owner) {
								Propertiesp2t.text = properties [p].name;
							} else if (logicPlayers [1] ==	services [s].owner) {
								Propertiesp2t.text = services [s].name;
							}
						}
					}
				}
				currentPlayer++;
			}
			currentPlayer = 0;
			turn.text = (System.Int32.Parse(turn.text) + 1).ToString();
			turnmax--;
		};
	
	}
		
	public void movePlayer(){

		Dice = new Dice ();
		logicPlayers [currentPlayer].pPosition += Dice.rollDice();
		if (logicPlayers [currentPlayer].pPosition > 39) {
			logicPlayers [currentPlayer].pPosition -= spaces.Length;
			logicPlayers [currentPlayer].cash += 200;
		}
		info.text = "Player " + (currentPlayer + 1) + " moved to cell " + logicPlayers[currentPlayer].pPosition.ToString();
		players[currentPlayer].transform.position = spaces [logicPlayers[currentPlayer].pPosition].position;
		}

	public void checkCase (){

		bool flag = false;
		do { 
			for(int i=0; i<trains.Length; i++) {
				for(int p=0; p<properties.Length; p++) {
					for(int s=0; s<services.Length; s++) {
						for(int co=0; co<comunity.Length; co++) {
							for(int ch=0; ch<chance.Length; ch++) {
								for(int f=0; f<freeplaces.Length; f++) {
									if (logicPlayers [currentPlayer].pPosition == properties [p].proPosition && flag == false) {
										if (logicPlayers [currentPlayer] == logicPlayers [0]) { 
											checkBuyProperties (logicPlayers [currentPlayer] , p, properties);
											cPlayer = currentPlayer;
											pos = p;
											flag = true;
											break;
										} else {
											checkBuyPropertiesBot (logicPlayers [currentPlayer] , p, properties);
											cPlayer = currentPlayer;
											pos = p;
											flag = true;
											break;
										}

									} else if (logicPlayers [currentPlayer].pPosition == trains[i].trainPosition && flag == false) {
											
										if (logicPlayers [currentPlayer] == logicPlayers [0]) { 	
											checkBuyTrains(logicPlayers [currentPlayer] , i, trains);
											cPlayer = currentPlayer;
											trainnum = i;
											flag = true;
											break;
										} else {
											checkBuyTrainsBot(logicPlayers [currentPlayer] , i, trains);
											cPlayer = currentPlayer;
											trainnum = i;
											flag = true;
											break;
										}

									 } else if (logicPlayers [currentPlayer].pPosition == services[s].serPosition && flag == false) {

										if (logicPlayers [currentPlayer] == logicPlayers [0]) {
											checkBuyServices(logicPlayers [currentPlayer] , s, services);
											cPlayer = currentPlayer;
											sernum = s;
											flag = true;
											break;
										} else {
											checkBuyServicesBot(logicPlayers [currentPlayer] , s, services);
											cPlayer = currentPlayer;
											sernum = s;
											flag = true;
											break;
										}

									} else if (logicPlayers [currentPlayer].pPosition == comunity[co].comPosition && flag == false) {
										cPlayer = currentPlayer;
										comunityCards();
										flag = true;
										break;

									} else if (logicPlayers [currentPlayer].pPosition == chance[ch].chancePosition && flag == false) {
										cPlayer = currentPlayer;
										chanceCards();
										flag = true;
										break;
									} else if (logicPlayers [currentPlayer].pPosition == freeplaces[f].freePosition && flag == false) {
										freePlace();
										flag = true;
										break; 
									} else if (logicPlayers [currentPlayer].pPosition == seniat.senPosition && flag == false) {

										if (logicPlayers [currentPlayer] == logicPlayers [0]) {
											cPlayer = currentPlayer;
											scenes = new Scenes ();
											scenes.ScenesPaySeniat();
											flag = true;
											break;
										} else {
											payRentSeniat1Bot();
											flag = true;
											break;
										}
									
									} else if (logicPlayers [currentPlayer].pPosition == impuesto.impPosition && flag == false) {

										if (logicPlayers [currentPlayer] == logicPlayers [0]) { 
											cPlayer = currentPlayer;
											scenes = new Scenes ();
											scenes.ScenesPayImp();
											flag = true;
											break; 
										} else {
											payImpBot ();
											flag = true;
											break;
										}

									} else if (logicPlayers [currentPlayer].pPosition == jail.jailPosition && flag == false){

										if (logicPlayers [currentPlayer] == logicPlayers [0]) {
											cPlayer = currentPlayer;
											scenes = new Scenes ();
											scenes.ScenesJail();
											flag = true;
											break; 
										} else {
											payJailBot ();
											flag = true;
											break;
										}
									}
								}	
							}
						}
					}
				}
			}
		}while(flag == false);
	}

	void checkBuyProperties(Players player, int p, Property[] properties){
		if (player = logicPlayers [0]) {
			if (player == properties [p].owner) {
				scenes = new Scenes ();
				scenes.ScenesBuyHouses (p);
			} else if (properties [p].owner == null) {
				scenes = new Scenes ();
				scenes.ScenesBuyPro (p);
			} else {
				scenes = new Scenes ();
				scenes.ScenesPayPro (p);
			}
		} 
	}

	void checkBuyPropertiesBot(Players player, int p, Property[] properties) {
		if (player == properties [p].owner) {
			if (properties [p].houses == 0) {
				buyHouse1Bot ();
			} else if (properties [p].houses == 1) {
				buyHouse2Bot ();
			} else if (properties [p].houses == 2) {
				buyHouse3Bot ();
			} else if (properties [p].houses == 3) {
				buyHouse4Bot ();
			} else if (properties [p].houses == 4) {
				buyHotelBot ();
			}
		} else if (properties [p].owner == null) {
			buyPropertyBot ();
		} else {
			payRentBot ();
		}
	}

	void checkBuyTrains(Players player, int i, Trains[] trains) {
		if (player = logicPlayers [0]) {
			if (player == trains [i].owner) {
				//next
			} else if (trains [i].owner == null) {
				scenes = new Scenes ();
				scenes.ScenesBuyTrains (i);
			} else {
				scenes = new Scenes ();
				scenes.ScenesPayTrains (i);
			}
		} 
	}

	void checkBuyTrainsBot(Players player, int i, Trains[] trains) {

		if (player == trains [i].owner) {
				//next
			} else if (trains [i].owner == null) {
				buyTrainsBot ();
			} else {
				payRentTrainsBot ();
			}
		}


	void checkBuyServices(Players player, int s, Services[] services) {

		if (player = logicPlayers [0]) {
			if (player == services[s].owner) {
				//next
			} else if (services[s].owner == null) {
				scenes = new Scenes ();
				scenes.ScenesBuyServices(s);

			} else {
				scenes = new Scenes ();
				scenes.ScenesPayServices(s);
			}
		}
	}

	void checkBuyServicesBot(Players player, int s, Services[] services) {

			if (player == services[s].owner) {
				//next
			} else if (services[s].owner == null) {
				buyServicesBot ();
			}
			else {
				payRentServicesBot();
			}
		}


	void comunityCards() {
		Comunity = new Comunity ();
		Comunity.ChestCards ();
	}

	void chanceCards() {
		Chance = new Chance ();
		Chance.ChanceCards();
	}

	void freePlace() {
		Debug.Log ("Escena de estacionamiento libre");
	}

	public void buyProperty() {

		if (logicPlayers[cPlayer].cash >= properties [pos].cost) {
			logicPlayers[cPlayer].cash -= properties [pos].cost;
			properties [pos].owner = logicPlayers[cPlayer];
		}
	}

	public void buyPropertyBot() {

		if (logicPlayers [1].cash >= properties [pos].cost + 300) {
			if (logicPlayers [1].cash >= properties [pos].cost) {
				logicPlayers [1].cash -= properties [pos].cost;
				properties [pos].owner = logicPlayers [1];
			}
		}
	}


	public void payRent() {

		if (logicPlayers [cPlayer].cash >= properties [pos].cost) {
			logicPlayers [cPlayer].cash -= properties [pos].rent;
			properties [pos].owner.cash += properties [pos].rent;
		} else {
			Application.LoadLevel ("Derrota");
		}

	}

	public void payRentBot() {

		if (logicPlayers [1].cash >= properties [pos].cost) {
			logicPlayers [1].cash -= properties [pos].rent;
			properties [pos].owner.cash += properties [pos].rent;
		} else {
			Application.LoadLevel ("Derrota");
		}

	}

	public void buyTrains() {

		if (logicPlayers[cPlayer].cash >= trains [trainnum].cost) {
			logicPlayers [cPlayer].cash -= trains [trainnum].cost;
			trains[trainnum].owner = logicPlayers[cPlayer];
		}
	}

	public void buyTrainsBot() {

		if (logicPlayers [1].cash >= trains [trainnum].cost + 200) {
			if (logicPlayers[1].cash >= trains [trainnum].cost) {
				logicPlayers [1].cash -= trains [trainnum].cost;
				trains[trainnum].owner = logicPlayers[1];
			}
		}
	}

	public void payRentTrains() {
		
		int cantrain = 0;
		for (int tr = 0; tr < trains.Length; tr++) {
			if (trains [tr].owner == logicPlayers [0]) {
				cantrain++;
			}
		}

		if (cantrain == 1) {
			trains [trainnum].rent = 25;
		} else if (cantrain == 2) {
			trains [trainnum].rent = 50;
		} else if (cantrain == 3) {
			trains [trainnum].rent = 100;
		} else if (cantrain == 4) {
			trains [trainnum].rent = 200;
		}

		if (logicPlayers [cPlayer].cash >= trains [trainnum].rent) {
			logicPlayers [cPlayer].cash -= trains [trainnum].rent ;
			trains[trainnum].owner.cash += trains [trainnum].rent ;
			trains [trainnum].rent = 25;
		} else {
			Application.LoadLevel ("Derrota");
		}
	}

	public void payRentTrainsBot() {

		int cantrain = 0;
		for (int tr = 0; tr < trains.Length; tr++) {
			if (trains [tr].owner == logicPlayers [0]){
				cantrain++;
			}
		}

		if (cantrain == 1) {
			trains [trainnum].rent = 25;
		} else if (cantrain == 2) {
			trains [trainnum].rent = 50;
		} else if (cantrain == 3) {
			trains [trainnum].rent = 100;
		} else if (cantrain == 4) {
			trains [trainnum].rent = 200;
		}
			
		if (logicPlayers [1].cash >= (trains [trainnum].rent)) {
			logicPlayers [1].cash -= trains [trainnum].rent;
			trains[trainnum].owner.cash += trains [trainnum].rent;
			trains [trainnum].rent = 25;
		} else {
			Application.LoadLevel ("Derrota");
		}
	}

	public void payRentSeniat1() {

		if (logicPlayers [cPlayer].cash >= System.Convert.ToInt32(logicPlayers [cPlayer].cash * 0.10)) {
			logicPlayers [cPlayer].cash -= System.Convert.ToInt32(logicPlayers [cPlayer].cash * 0.10);
		} else {
			Application.LoadLevel ("Derrota");
		}
	}

	public void payRentSeniat1Bot() {

		if (logicPlayers [1].cash >= System.Convert.ToInt32(logicPlayers [1].cash * 0.10)) {
			logicPlayers [1].cash -= System.Convert.ToInt32(logicPlayers [1].cash * 0.10);
		} else {
			Application.LoadLevel ("Derrota");
		}
	}

	public void payRentSeniat2() {
		if (logicPlayers [cPlayer].cash >= 200) {
			logicPlayers [cPlayer].cash -= 200;
		} else {
			Application.LoadLevel ("Derrota");
		}	
	}

	public void buyServices() {

		if (logicPlayers [cPlayer].cash >= services[sernum].cost) {
			logicPlayers [cPlayer].cash -= services[sernum].cost;
			services[sernum].owner = logicPlayers[cPlayer];
		}
	}

	public void buyServicesBot() {

		if (logicPlayers [1].cash >= services [sernum].cost + 250) {
			if (logicPlayers [1].cash >= services [sernum].cost) {
				logicPlayers [1].cash -= services [sernum].cost;
				services [sernum].owner = logicPlayers [1];
			}
		}
	}

	public void payRentServices() {

		services [sernum].rent = dicenumber * 4;
		if (logicPlayers [cPlayer].cash >= services [sernum].rent) {
			//services [sernum].rent = 12 * 4;
			logicPlayers [cPlayer].cash -= services[sernum].rent;
			services[sernum].owner.cash += services[sernum].rent;
		} else {
			Application.LoadLevel ("Derrota");
		}
	}

	public void payRentServicesBot() {

		services [sernum].rent = dicenumber * 4;
		if (logicPlayers [1].cash >= services [sernum].rent) {
			logicPlayers [1].cash -= services[sernum].rent;
			services[sernum].owner.cash += services[sernum].rent;
		} else {
			Application.LoadLevel ("Derrota");
		}
	}

	public void payImp() {

		if (logicPlayers [cPlayer].cash >= 75) {
			logicPlayers [cPlayer].cash -= 75;
		} else {
			Application.LoadLevel ("Derrota");
		}
	}

	public void payJail() {

		if (logicPlayers [cPlayer].cash >= 500) {
			logicPlayers [cPlayer].cash -= 500;
		} else {
			Application.LoadLevel ("Derrota");
		}
	}

	public void payImpBot() {

		if (logicPlayers [1].cash >= 75) {
			logicPlayers [1].cash -= 75;
		} else {
			Application.LoadLevel ("Derrota");
		}
	}

	public void payJailBot() {

		if (logicPlayers [1].cash >= 500) {
			logicPlayers [1].cash -= 500;
		} else {
			Application.LoadLevel ("Derrota");
		}
	}

	public void CardJail() {

		if (logicPlayers [cPlayer].CarcelCard == 1) {
			logicPlayers [cPlayer].CarcelCard = 0;
		} else {
			Application.LoadLevel ("Derrota");
		}
	}

	public void buyHouse1() {

		if (logicPlayers[cPlayer].cash >= properties[pos].housescost) {
			logicPlayers[cPlayer].cash -= properties [pos].housescost;
			properties[pos].houses = 1;
			properties[pos].rent = properties[pos].rentr1 ;
		}

	}

	public void buyHouse1Bot() {

		if (logicPlayers [1].cash >= properties [pos].housescost + 200) {
			if (logicPlayers [1].cash >= properties [pos].housescost) {
				logicPlayers [1].cash -= properties [pos].housescost;
				properties [pos].houses = 1;
				properties [pos].rent = properties [pos].rentr1;
			}
		}
	}

	public void buyHouse2() {

		if (logicPlayers[cPlayer].cash >= properties [pos].housescost && properties[pos].houses == 1 ) {
			logicPlayers[cPlayer].cash -= properties [pos].housescost;
			properties[pos].houses = 2;
			properties[pos].rent = properties[pos].rentr2 ;
		}
	
	}

	public void buyHouse2Bot() {

		if (logicPlayers [1].cash >= properties [pos].housescost + 300) {
			if (logicPlayers[cPlayer].cash >= properties [pos].housescost && properties[pos].houses == 1 ) {
				logicPlayers[cPlayer].cash -= properties [pos].housescost;
				properties[pos].houses = 2;
				properties[pos].rent = properties[pos].rentr2 ;
			}
		}
	}

	public void buyHouse3() {

		if (logicPlayers[cPlayer].cash >= properties [pos].housescost && properties[pos].houses == 2 ) {
			logicPlayers[cPlayer].cash -= properties [pos].housescost;
			properties[pos].houses = 3;
			properties[pos].rent = properties[pos].rentr3 ;
		}

	}

	public void buyHouse3Bot() {

		if (logicPlayers [1].cash >= properties [pos].housescost + 350) {	
			if (logicPlayers [cPlayer].cash >= properties [pos].housescost && properties [pos].houses == 2) {
				logicPlayers [cPlayer].cash -= properties [pos].housescost;
				properties [pos].houses = 3;
				properties [pos].rent = properties [pos].rentr3;
			}
		}
	}

	public void buyHouse4() {

		if (logicPlayers[cPlayer].cash >= properties [pos].housescost && properties[pos].houses == 3 ) {
			logicPlayers[cPlayer].cash -= properties [pos].housescost;
			properties[pos].houses = 4;
			properties[pos].rent = properties[pos].rentr4 ;
		}
	}

	public void buyHouse4Bot() {

		if (logicPlayers [1].cash >= properties [pos].housescost + 400) {	
			if (logicPlayers [cPlayer].cash >= properties [pos].housescost && properties [pos].houses == 3) {
				logicPlayers [cPlayer].cash -= properties [pos].housescost;
				properties [pos].houses = 4;
				properties [pos].rent = properties [pos].rentr4;
			}
		}
	}

	public void buyHotel() {

		if (logicPlayers[cPlayer].cash >= properties [pos].housescost && properties[pos].houses == 4 ) {
			logicPlayers[cPlayer].cash -= properties [pos].housescost;
			properties[pos].hotel = 1;
			properties[pos].rent = properties[pos].rentp ;
		}

	}

	public void buyHotelBot() {

		if (logicPlayers [1].cash >= properties [pos].housescost + 300) {
			if (logicPlayers [cPlayer].cash >= properties [pos].housescost && properties [pos].houses == 4) {
				logicPlayers [cPlayer].cash -= properties [pos].housescost;
				properties [pos].hotel = 1;
				properties [pos].rent = properties [pos].rentp;
			}
		}
	}
}