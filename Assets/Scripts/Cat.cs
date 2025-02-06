using UnityEngine;

public class Cat : Animal
{
    private void Start()
    {
        Name = "Sammy";
    }
    public override void MakeSound()
    {
        Debug.Log("Cat Meows" + Name);
       
    }
}
