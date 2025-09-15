using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Chicken Sam;
    private Cow Jam;

    private void Start()
    {
        Debug.Log("**********Welcome to the Farn sim**********");

        Sam = new Chicken("Sam", 10 , 10 );
        Jam = new Cow("Jam", 15, 15, 0);

        Debug.Log(Sam.Name + "and" + Jam.Name + " are living in the farm ");



        Sam.GetStatus();
        Sam.MakeSound();
        Sam.Feed("Corn");
        Sam.GetStatus();
        Sam.Sleep();
        Sam.GetStatus();

        Jam.GetStatus();
        Jam.MakeSound();
        Jam.Feed("Hay");
        Jam.GetStatus();
        Jam.GetStatus();


    }
}
