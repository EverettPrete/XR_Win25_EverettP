using UnityEngine;

public class Snake : Animal
{
    Color Color = Color.green;
    private void Start()
    {
        Name = "bubby";
    }

    public override void MakeSound()
    {
        Debug.Log("Snake Hisses");
    }



}
