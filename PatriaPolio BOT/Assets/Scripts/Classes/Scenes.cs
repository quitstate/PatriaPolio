using UnityEngine;
using System.Collections;

public class Scenes : MonoBehaviour {

	public Chance chance;

	public void ScenesBuyPro (int position) {

		switch (position) {

		case 0:
			
			Application.LoadLevel ("Scenes/Av.Compra/Av.IslaDorada");
			break;

		case 1:

			Application.LoadLevel("Scenes/Av.Compra/Av.Altagracia");
			break;

		case 2:
			Application.LoadLevel("Scenes/Av.Compra/Av.LaH");
			break;

		case 3:
			Application.LoadLevel("Scenes/Av.Compra/Av.Cecilio");
			break;

		case 4:
			Application.LoadLevel("Scenes/Av.Compra/Av.Goajira");
			break;

		case 5:
			Application.LoadLevel("Scenes/Av.Compra/Av.SantaRita");
			break;

		case 6:
			Application.LoadLevel("Scenes/Av.Compra/Av.5Julio");
			break;
		
		case 7:
			Application.LoadLevel("Scenes/Av.Compra/Av.Infante");
			break;

		case 8:
			Application.LoadLevel("Scenes/Av.Compra/Av.Ricaurte");
			break;

		case 9:
			Application.LoadLevel("Scenes/Av.Compra/Av.Padilla");
			break;

		case 10:
			Application.LoadLevel("Scenes/Av.Compra/Av.Libertador");
			break;

		case 11:
			Application.LoadLevel("Scenes/Av.Compra/Av.LosHaticos");
			break;
		
		case 12:
			Application.LoadLevel("Scenes/Av.Compra/Av.LasDelicias");
			break;

		case 13:
			Application.LoadLevel("Scenes/Av.Compra/Av.Sabaneta");
			break;

		case 14:
			Application.LoadLevel("Scenes/Av.Compra/Av.Cumana");
			break;

		case 15:
			Application.LoadLevel("Scenes/Av.Compra/Av.BellaVista");
			break;

		case 16:
			Application.LoadLevel("Scenes/Av.Compra/Jardines");
			break;

		case 17:
			Application.LoadLevel("Scenes/Av.Compra/Av.Dios");
			break;

		case 18:
			Application.LoadLevel("Scenes/Av.Compra/Av.Universidad");
			break;

		case 19:
			Application.LoadLevel("Scenes/Av.Compra/Av.ElPao");
			break;

		case 20:
			Application.LoadLevel("Scenes/Av.Compra/PlazaMercedes");
			break;

		case 21:
			Application.LoadLevel("Scenes/Av.Compra/Bulevard");
			break;

		}
	}

	public void ScenesPayPro (int position) {

		switch (position) {

		case 0:

			Application.LoadLevel ("Scenes/Av.Renta/RAv.IslaDorada");
			break;

		case 1:
			Application.LoadLevel("Scenes/Av.Renta/RAv.Altagracia");
			break;

		case 2:
			Application.LoadLevel("Scenes/Av.Renta/RAv.LaH");
			break;

		case 3:
			Application.LoadLevel("Scenes/Av.Renta/RAv.Cecilio");
			break;

		case 4:
			Application.LoadLevel("Scenes/Av.Renta/RAv.Goajira");
			break;

		case 5:
			Application.LoadLevel("Scenes/Av.Renta/RAv.SantaRita");
			break;

		case 6:
			Application.LoadLevel("Scenes/Av.Renta/RAv.5Julio");
			break;

		case 7:
			Application.LoadLevel("Scenes/Av.Renta/RAv.Infante");
			break;

		case 8:
			Application.LoadLevel("Scenes/Av.Renta/RAv.Ricaurte");
			break;

		case 9:
			Application.LoadLevel("Scenes/Av.Renta/RAv.Padilla");
			break;

		case 10:
			Application.LoadLevel("Scenes/Av.Renta/RAv.Libertador");
			break;

		case 11:
			Application.LoadLevel("Scenes/Av.Renta/RAv.LosHaticos");
			break;

		case 12:
			Application.LoadLevel("Scenes/Av.Renta/RAv.LasDelicias");
			break;

		case 13:
			Application.LoadLevel("Scenes/Av.Renta/RAv.Sabaneta");
			break;

		case 14:
			Application.LoadLevel("Scenes/Av.Renta/RAv.Cumana");
			break;

		case 15:
			Application.LoadLevel("Scenes/Av.Renta/RAv.BellaVista");
			break;

		case 16:
			Application.LoadLevel("Scenes/Av.Renta/RJardines");
			break;

		case 17:
			Application.LoadLevel("Scenes/Av.Renta/RAv.Dios");
			break;

		case 18:
			Application.LoadLevel("Scenes/Av.Renta/RAv.Universidad");
			break;

		case 19:
			Application.LoadLevel("Scenes/Av.Renta/RAv.ElPao");
			break;

		case 20:
			Application.LoadLevel("Scenes/Av.Renta/RPlazaMercedes");
			break;

		case 21:
			Application.LoadLevel("Scenes/Av.Renta/RBulevard");
			break;

		}
	}

	public void ScenesBuyTrains (int position) {

		switch (position) {

		case 0:

			Application.LoadLevel ("Scenes/Trenes Compra/LosDosCaminos");
			break;

		case 1:

			Application.LoadLevel ("Scenes/Trenes Compra/La Hoyada");
			break;

		case 2:

			Application.LoadLevel ("Scenes/Trenes Compra/Los Cortijos");
			break;

		case 3:

			Application.LoadLevel ("Scenes/Trenes Compra/Chacaito");
			break;

		}
	}

	public void ScenesPayTrains (int position) {

		switch (position) {

		case 0:

			Application.LoadLevel ("Scenes/Trenes Renta/LosDosCaminos");
			break;

		case 1:

			Application.LoadLevel ("Scenes/Trenes Renta/La Hoyada");
			break;

		case 2:

			Application.LoadLevel ("Scenes/Trenes Renta/Los Cortijos");
			break;

		case 3:

			Application.LoadLevel ("Scenes/Trenes Renta/Chacaito");
			break;

		}
	}

	public void ScenesPaySeniat () {

		Application.LoadLevel ("Scenes/Vzla Renta/Seniat");
	}


	public void ScenesBuyServices (int position) {

		switch (position) {

		case 0:

			Application.LoadLevel ("Scenes/Vzla Compra/Corpoelec");
			break;

		case 1:

			Application.LoadLevel ("Scenes/Vzla Compra/Hidrolago");
			break;

		
		}
	}


	public void ScenesPayServices (int position) {

		switch (position) {

		case 0:

			Application.LoadLevel ("Scenes/Vzla Renta/Corpoelec");
			break;

		case 1:

			Application.LoadLevel ("Scenes/Vzla Renta/Hidrolago");
			break;


		}
	}

	public void ScenesPayImp () {

		Application.LoadLevel ("Scenes/Vzla Renta/Lujo");
	}

	public void ScenesJail () {

		Application.LoadLevel ("Scenes/Reten");
	}



	public void ScenesChance (int i) {

		switch (i) {

		case 1:

			Application.LoadLevel ("Scenes/Chance/Chance (1)");
			break;

		case 2:


			Application.LoadLevel ("Scenes/Chance/Chance (2)");
			break;

		case 3:

			Application.LoadLevel ("Scenes/Chance/Chance (3)");
			break;

		case 4:

			Application.LoadLevel ("Scenes/Chance/Chance (4)");
			break;

		case 5:

			Application.LoadLevel ("Scenes/Chance/Chance (5)");
			break;

		case 6:

			Application.LoadLevel ("Scenes/Chance/Chance (6)");
			break;

		case 7:

			Application.LoadLevel ("Scenes/Chance/Chance (7)");
			break;

		case 8:

			Application.LoadLevel ("Scenes/Chance/Chance (8)");
			break;

		case 9:

			Application.LoadLevel ("Scenes/Chance/Chance (9)");
			break;

		case 10:

			Application.LoadLevel ("Scenes/Chance/Chance (10)");
			break;

		case 11:

			Application.LoadLevel ("Scenes/Chance/Chance (11)");
			break;

		case 12:

			Application.LoadLevel ("Scenes/Chance/Chance (12)");
			break;

		case 13:

			Application.LoadLevel ("Scenes/Chance/Chance (13)");
			break;

		case 14:

			Application.LoadLevel ("Scenes/Chance/Chance (14)");
			break;

		case 15:

			Application.LoadLevel ("Scenes/Chance/Chance (15)");
			break;

		case 16:

			Application.LoadLevel ("Scenes/Chance/Chance (16)");
			break;

		}
	}

	public void ScenesChest (int i) {

		switch (i) {

		case 1:

			Application.LoadLevel ("Scenes/Chest/Chest (1)");
			break;

		case 2:

			Application.LoadLevel ("Scenes/Chest/Chest (2)");
			break;

		case 3:

			Application.LoadLevel ("Scenes/Chest/Chest (3)");
			break;

		case 4:

			Application.LoadLevel ("Scenes/Chest/Chest (4)");
			break;

		case 5:

			Application.LoadLevel ("Scenes/Chest/Chest (5)");
			break;

		case 6:

			Application.LoadLevel ("Scenes/Chest/Chest (6)");
			break;

		case 7:

			Application.LoadLevel ("Scenes/Chest/Chest (7)");
			break;

		case 8:

			Application.LoadLevel ("Scenes/Chest/Chest (8)");
			break;

		case 9:

			Application.LoadLevel ("Scenes/Chest/Chest (9)");
			break;

		case 10:

			Application.LoadLevel ("Scenes/Chest/Chest (10)");
			break;

		case 11:

			Application.LoadLevel ("Scenes/Chest/Chest (11)");
			break;

		case 12:

			Application.LoadLevel ("Scenes/Chest/Chest (12)");
			break;

		case 13:

			Application.LoadLevel ("Scenes/Chest/Chest (13)");
			break;

		case 14:

			Application.LoadLevel ("Scenes/Chest/Chest (14)");
			break;

		case 15:

			Application.LoadLevel ("Scenes/Chest/Chest (15)");
			break;

		case 16:

			Application.LoadLevel ("Scenes/Chest/Chest (16)");
			break;
		
		}
	}


	public void ScenesBuyHouses (int position) {

		switch (position) {

		case 0:

			Application.LoadLevel ("Scenes/CompraCasas/RrAv.IslaDorada");

			break;

		case 1:

			Application.LoadLevel("Scenes/CompraCasas/RrAv.Altagracia");
			break;

		case 2:
			Application.LoadLevel("Scenes/CompraCasas/RrAv.LaH");
			break;

		case 3:
			Application.LoadLevel("Scenes/CompraCasas/RrAv.Cecilio");
			break;

		case 4:
			Application.LoadLevel("Scenes/CompraCasas/RrAv.Goajira");
			break;

		case 5:
			Application.LoadLevel("Scenes/CompraCasas/RrAv.SantaRita");
			break;

		case 6:
			Application.LoadLevel("Scenes/CompraCasas/RrAv.5Julio");
			break;

		case 7:
			Application.LoadLevel("Scenes/CompraCasas/RrAv.Infante");
			break;

		case 8:
			Application.LoadLevel("Scenes/CompraCasas/RrAv.Ricaurte");
			break;

		case 9:
			Application.LoadLevel("Scenes/CompraCasas/RrAv.Padilla");
			break;

		case 10:
			Application.LoadLevel("Scenes/CompraCasas/RrAv.Libertador");
			break;

		case 11:
			Application.LoadLevel("Scenes/CompraCasas/RrAv.LosHaticos");
			break;

		case 12:
			Application.LoadLevel("Scenes/CompraCasas/RrAv.LasDelicias");
			break;

		case 13:
			Application.LoadLevel("Scenes/CompraCasas/RrAv.Sabaneta");
			break;

		case 14:
			Application.LoadLevel("Scenes/CompraCasas/RrAv.Cumana");
			break;

		case 15:
			Application.LoadLevel("Scenes/CompraCasas/RrAv.BellaVista");
			break;

		case 16:
			Application.LoadLevel("Scenes/CompraCasas/RrJardines");
			break;

		case 17:
			Application.LoadLevel("Scenes/CompraCasas/RrAv.Dios");
			break;

		case 18:
			Application.LoadLevel("Scenes/CompraCasas/RrAv.Universidad");
			break;

		case 19:
			Application.LoadLevel("Scenes/CompraCasas/RrAv.ElPao");
			break;

		case 20:
			Application.LoadLevel("Scenes/CompraCasas/RrPlazaMercedes");
			break;

		case 21:
			Application.LoadLevel("Scenes/CompraCasas/RrBulevard");
			break;
		}
	}
}
