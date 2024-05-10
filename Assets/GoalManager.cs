using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    [SerializeField] private GameObject surveyObject;
    public bool check = true;
    private void OnTriggerEnter(Collider other)
    {
        //When in contact with the player, the survey appears.
        if(other.CompareTag("Player"))
        {
            if (check && surveyObject.activeSelf == true)
            {
                check = false;
                surveyObject.SetActive(false);

            }
            else if (check != false)
            {
                surveyObject.SetActive(true);
                check = false;
            }
        }
    }
}
