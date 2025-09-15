using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken
{

    public string Name { get; private set; }
    public int Hunger { get; private set; }
    public int Happiness { get; private set; }

    public int Eggs { get; private set; }

    public Chicken(string name, int hunger, int happiness)
    {
        Name = name;
        Hunger = hunger;
        Happiness = happiness;
        Eggs = 0;
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
        Debug.Log(Name + "Cluck!");
    }

    public void Feed(string Food)
    {
        Debug.Log("Eats" + Food + "feels happy" + Happiness);
        AdjustHunger(-5);
        AdjustHappiness(+5);
    }

    public void GetStatus()
    {
        Debug.Log($"{Name} --> Hunger {Hunger} || Total {Eggs}");
    }

    public void Sleep()
    {
        Debug.Log(Name + " slept and feels happy ");
        AdjustHappiness(10);
        AdjustHunger(2);
    }
}

