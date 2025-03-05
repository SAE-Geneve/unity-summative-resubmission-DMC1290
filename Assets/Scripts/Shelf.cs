using System.Collections.Generic;
using UnityEngine;

public class Shelf : MonoBehaviour
{
    [SerializeField] private Transform[] shelfItems;
    [SerializeField] private Transform[] shelfArray;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // for ()
        
             Transform randomShelf = shelfArray[Random.Range(0, shelfArray.Length)];
        

    }

    
}
