using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tips : MonoBehaviour {
public Text myText;

public string[] TipDescriptions = 
{
    "Try not sucking at the game",
    "Try clicking on the environment around you to activate their power",
    "Red asteroids will explode once they are clicked",
    "You will complete the level when the progress bar on top fills completly",
    "Have your ship fly through the yellow portal to recieve a speed boost",
	"Your health is shown on the top left corner of the screen, you have 4 hits before your ship blows up",
	"You can pick health back up by colliding with the red battery packs",
	"Crashing against asteroids will only take away one health from your health bar",
	"Your ship will slow down if you get too close to a black hole",
	"Crashing against energy shields will result in immediate death",
	"Flying outside screen limits will result in immediate death",
};

void Start()
{
    string myString = TipDescriptions [Random.Range (0, TipDescriptions.Length)];
    myText.text = myString;
}
}
