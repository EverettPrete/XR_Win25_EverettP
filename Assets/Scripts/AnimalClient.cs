using UnityEngine;

public class AnimalClient : MonoBehaviour
{

    [SerializeField] Animal[] animals; 

    void Start()
    {
        
      foreach (var animal in animals)
        {
            animal.MakeSound();
        }  

    }

}
