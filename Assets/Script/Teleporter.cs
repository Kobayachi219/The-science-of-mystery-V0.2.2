using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private Transform destination;
    
    

    public Transform GetDestination()
    {
        return destination;
    }

 
}