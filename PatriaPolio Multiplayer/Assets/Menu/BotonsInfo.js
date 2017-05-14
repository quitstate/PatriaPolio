public function BotonInfo() {

	SceneManagement.SceneManager.LoadScene("Info");
}

public function BotonContinue() {
	Time.timeScale = 1;
}

public function BotonBack() {
	SceneManagement.SceneManager.LoadScene("StartGame");
}


public function BotonExitGame() {

	SceneManagement.SceneManager.Quit();
}