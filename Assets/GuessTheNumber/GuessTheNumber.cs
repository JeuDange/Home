using TMPro;
using UnityEngine; //r�gle d'import, �a rend �a utilisable dans Unity

public class GuessTheNumber : MonoBehaviour //pulic=on cr�e quelque chose dispo dans ts le projet visible en inspector / class=on cr�e un plan (une maison) / MonoBehaviour=pr cr�er des composants customs (class de base)
{

    public TMP_Text messageText;
    public TMP_InputField numberInput;

    private int randomNumber;

    private void Start()
    {
        ResetGame(); //on appelle la fonction resetgame pour la faire directement et on fait pas l'inverse car c'est le d�but
    }

    public void Try()
    {
        if (string.IsNullOrWhiteSpace(numberInput.text) == true) //voir si y'a que  des caract�res valides 
        {
            messageText.text = "Please enter a valid number.";
            numberInput.text = "";
            return; 
        }

        if(int.TryParse(numberInput.text, out int playerNumber)) //Lire du texte et d�duire quelque chose out= renvoyer une deuxi�me valeur
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
            //Si playerNumber est �gal � randomNumber
                //Victoire (changer le message, reset le champ texte)
            //Si playerNumber est sup�rieur � randomNumber
                //Annoncer "moins"
            //Si playerNumber est inf�rieur � randomNumber
                // Annoncer "plus"
            // Valeur = variable / verbe = fonction / nom = cr�er une class
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
