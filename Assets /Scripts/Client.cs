using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{

	public int Location;
    public bool Formal;
    public bool Woman;

    void Start()
    {
        ClothesRequirements requirements = new ClothesRequirements();

        requirements.Woman = Woman;
        requirements.Location = Mathf.Max(Location);
        requirements.Woman = Formal;
        requirements.Formal = Formal;

        ClothesFactory factory = new ClothesFactory(requirements);
        IClothes v = factory.Create();
        Debug.Log(v);
    }

    void Update()
    {
        
    }
}