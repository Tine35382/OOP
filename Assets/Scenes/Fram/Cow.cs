using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow 
{
    public string Name { get; private set; }
    public int Hunger { get; private set; }
    public int Happiness { get; private set; }

    public float Milk { get; private set; }

    public Cow(string name, int hunger, int happiness, float milk)
    {
        Name = name;
        Hunger = hunger;
        Happiness = happiness;
        Milk = milk;
    }

    public void AdjustHunger(int amount)
    {
        Hunger = Mathf.Clamp(Hunger + amount, 0, 50);
    }

    public void AdjustHappiness(int amount)
    {
        Happiness = Mathf.Clamp(Happiness + amount, 0, 50);
    }

    public void MakeSound()
    {
        Debug.Log(Name + "Moooo!");
    }

    public void Feed(string Food)
    {
        Debug.Log("Eats" + Food + "feels happy" + Happiness);
        AdjustHunger(-5);
        AdjustHappiness(+5);
    }

    public void GetStatus()
    {
        Debug.Log($"{Name} --> Hunger: {Hunger} || Total Milk: {Milk} || happiness : {Happiness}");
    }

    public void Sleep()
    {
        Debug.Log(Name + " slept and feels happy ");
        AdjustHappiness(10);
        AdjustHunger(2);
    }
}
