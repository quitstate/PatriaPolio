using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BotonsInfo : MonoBehaviour {

	public static BotonsInfo botonsinfo;
	public Chance chance;
	public CanvasP canvasp;
	public CanvasD canvasd;

	void Awake (){
		if (botonsinfo == null) {
			botonsinfo = this;
			DontDestroyOnLoad (gameObject);
		} else if (botonsinfo != this) {
			Destroy (gameObject);	
		}
	}


	public void BotonInfo() {
		Application.LoadLevel ("Info");

		Time.timeScale = 0;
	}

	public void BotonContinue() {
		Time.timeScale = 1;
	}

	public void BotonBack() {
		Application.LoadLevel ("StartGame");
	}
		
	public void BotonBuy() {

		startGame.StartGame.buyProperty();
		Application.LoadLevel ("StartGame");

	}

	public void BotonPay() {

		startGame.StartGame.payRent ();
		Application.LoadLevel ("StartGame");

	}


	public void BotonBuyTrains() {

		startGame.StartGame.buyTrains();
		Application.LoadLevel ("StartGame");

	}

	public void BotonPayTrains() {

		startGame.StartGame.payRentTrains ();
		Application.LoadLevel ("StartGame");

	}

	public void BotonPaySeniat1() {

		startGame.StartGame.payRentSeniat1 ();
		Application.LoadLevel ("StartGame");

	}

	public void BotonPaySeniat2() {

		startGame.StartGame.payRentSeniat2 ();
		Application.LoadLevel ("StartGame");

	}


	public void BotonBuyServices() {

		startGame.StartGame.buyServices();
		Application.LoadLevel ("StartGame");

	}

	public void BotonPayServices() {

		startGame.StartGame.payRentServices();
		Application.LoadLevel ("StartGame");

	}

	public void BotonPayImp() {

		startGame.StartGame.payImp ();
		Application.LoadLevel ("StartGame");

	}

	public void BotonPayJail() {

		startGame.StartGame.payJail ();
		Application.LoadLevel ("StartGame");

	}

	public void BotonUseCardJail() {

		startGame.StartGame.CardJail ();
		Application.LoadLevel ("StartGame");

	}

	public void BotonRefresh() {
		canvasp = new CanvasP ();
		canvasp.BotonRefresh ();
	}

	public void BotonRefreshLoser() {
		canvasd = new CanvasD ();
		canvasd.BotonRefreshLoser ();
	}


	public void Lose() {
		Application.LoadLevel ("Derrota");
	}

	public void BotonBuyHouse1() {

		startGame.StartGame.buyHouse1();
		Application.LoadLevel ("StartGame");

	}

	public void BotonBuyHouse2() {

		startGame.StartGame.buyHouse2();
		Application.LoadLevel ("StartGame");

	}

	public void BotonBuyHouse3() {

		startGame.StartGame.buyHouse3 ();
		Application.LoadLevel ("StartGame");

	}

	public void BotonBuyHouse4() {

		startGame.StartGame.buyHouse4 ();
		Application.LoadLevel ("StartGame");

	}

	public void BotonBuyHotel() {

		startGame.StartGame.buyHotel ();
		Application.LoadLevel ("StartGame");

	}

	public void BotonExitGame() {
		Application.Quit ();
	}

}
