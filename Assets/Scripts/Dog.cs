using UnityEngine;

public class Dog : Animal
{
    private void Start()
    {
        Name = "Dug";
    }
    public override void MakeSound()
    {
           Debug.Log("Dog barks");
    }
}
