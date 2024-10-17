using TMPro;
using UnityEngine; //règle d'import, ça rend ça utilisable dans Unity

public class GuessTheNumber : MonoBehaviour //pulic=on crée quelque chose dispo dans ts le projet visible en inspector / class=on crée un plan (une maison) / MonoBehaviour=pr créer des composants customs (class de base)
{

    public TMP_Text messageText;
    public TMP_InputField numberInput;

    private int randomNumber;

    private void Start()
    {
        ResetGame(); //on appelle la fonction resetgame pour la faire directement et on fait pas l'inverse car c'est le début
    }

    public void Try()
    {
        if (string.IsNullOrWhiteSpace(numberInput.text) == true) //voir si y'a que  des caractères valides 
        {
            messageText.text = "Please enter a valid number.";
            numberInput.text = "";
            return; 
        }

        if(int.TryParse(numberInput.text, out int playerNumber)) //Lire du texte et déduire quelque chose out= renvoyer une deuxième valeur
        {
            if (playerNumber == randomNumber)
            {
                messageText.text = "VICTORY !";
            }
            else if (playerNumber > randomNumber)
            {
                messageText.text = "Lower...";
            }
            else if (playerNumber < randomNumber)
            {
                messageText.text = "Greater...";
            }
            //Si playerNumber est égal à randomNumber
                //Victoire (changer le message, reset le champ texte)
            //Si playerNumber est supérieur à randomNumber
                //Annoncer "moins"
            //Si playerNumber est inférieur à randomNumber
                // Annoncer "plus"
            // Valeur = variable / verbe = fonction / nom = créer une class
        }
        else
        {
            messageText.text = "Please enter a valid number.";
        }

        numberInput.text = "";

    }

    public void ResetGame()
    {
        randomNumber = Random.Range(1, 100 + 1);
        Debug.Log("Generated number: " + randomNumber);
        messageText.text = "Guess the number...";
    }

}
