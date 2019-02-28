using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RunCountDown : MonoBehaviour 
{

    private Text label;
    public int number = 150;
    
    IEnumerator Start ()
    {
        {
        label = GetComponent<Text>();
    
        while (number > 0)
        {
            yield return new WaitForSeconds(1);
            label.text = number.ToString();
            number--;
        }
            yield return new WaitForSeconds(1);
            label.text = "You Win!";
        }
    }
}

//WhileLoops
