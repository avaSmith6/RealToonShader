using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    [SerializeField] private GameObject surveyObject;
    private void OnTriggerEnter(Collider other)
    {
        //When in contact with the player, the survey appears.
        if(other.CompareTag("Player"))
        {
            surveyObject.SetActive(true);
        }
    }
}
