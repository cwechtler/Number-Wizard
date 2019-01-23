using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	
	public int maxGuessesAllowed = 10;
	public Text text;
	
	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	void Update(){
		if (Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit();
		}
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		NextGuess();
			
	}
	
	public void GuessHigher(){
		min = guess;
		NextGuess();
	}
	
	public void GuessLower(){
		max = guess;
		NextGuess();
	}
	
	void NextGuess () {
		guess = Random.Range(min,max+1);
			text.text = guess.ToString();
			maxGuessesAllowed = maxGuessesAllowed -1;
			if(maxGuessesAllowed <= 0){
				SceneManager.LoadScene("Lose");
			}
	}
}