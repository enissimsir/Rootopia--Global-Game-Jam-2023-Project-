using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EggFinish : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Egg1"))
        {
            collision.GetComponent<Animator>().Play("EggFinish");
            /*
            if(MineralCollecter.Instance.blueDiaCounter >= 2)
            {
                ObjectiveManager.Instance.blueDiaObjective.gameObject.SetActive(true);
                ObjectiveManager.Instance.blueDiaObjectiveComplete.gameObject.SetActive(true);
            }
            if(MineralCollecter.Instance.blueBubbleCounter >= 2)
            {
                ObjectiveManager.Instance.blueBubbleObjective.gameObject.SetActive(true);
                ObjectiveManager.Instance.blueBubbleObjectiveComplete.gameObject.SetActive(true);
            }
            */
            ObjectiveManager.Instance.icyYildiz.gameObject.SetActive(true);
            ObjectiveManager.Instance.icyYildizComplete.gameObject.SetActive(true);
            LevelMapManagement.isCompleted[0] = true;


            StartCoroutine(ReturnLevelMap());
;       }

        if(collision.gameObject.CompareTag("Egg2"))
        {
            collision.GetComponent<Animator>().Play("EggFinish");
            /*
            if(MineralCollecter.Instance.redKuvarsCounter >= 3)
            {
                ObjectiveManager.Instance.redKuvarsObjective.gameObject.SetActive(true);
                ObjectiveManager.Instance.redKuvarsObjectiveComplete.gameObject.SetActive(true);
            }
            if(MineralCollecter.Instance.redstickCounter >= 2)
            {
                ObjectiveManager.Instance.redStickObjective.gameObject.SetActive(true);
                ObjectiveManager.Instance.redStickObjectiveComplete.gameObject.SetActive(true);
            }
            */
            ObjectiveManager.Instance.lavaYildiz.gameObject.SetActive(true) ;
            ObjectiveManager.Instance.lavaYildizComplete.gameObject.SetActive(true) ;
            LevelMapManagement.isCompleted[1] = true;
            StartCoroutine(ReturnLevelMap());
        }

        if(collision.gameObject.CompareTag("Egg3"))
        {
            collision.GetComponent<Animator>().Play("EggFinish");
            /*
            if(MineralCollecter.Instance.orangeKuvarsCounter >= 3)
            {
                ObjectiveManager.Instance.orangeKuvarsObjective.gameObject.SetActive(true);
                ObjectiveManager.Instance.orangeKuvarsObejctiveComplete.gameObject.SetActive(true);
            }
            if(MineralCollecter.Instance.yesimcounter >= 3)
            {
                ObjectiveManager.Instance.greenKuvarsObjective.gameObject.SetActive(true);
                ObjectiveManager.Instance.greenKuvarsObjectiveComplete.gameObject.SetActive(true);
            }
            */
            ObjectiveManager.Instance.slimeYildiz.gameObject.SetActive(true);
            ObjectiveManager.Instance.slimeYildizComplete.gameObject.SetActive(true);
            LevelMapManagement.isCompleted[2] = true;
            StartCoroutine(ReturnLevelMap());
        }
    }

    private IEnumerator ReturnLevelMap()
    {
        /*
        MineralCollecter.Instance.blueBubbleCounter= 0;
        MineralCollecter.Instance.blueDiaCounter= 0;
        MineralCollecter.Instance.redKuvarsCounter = 0;
        MineralCollecter.Instance.redstickCounter= 0;
        MineralCollecter.Instance.purpleKuvarsCounter= 0;
        MineralCollecter.Instance.orangeKuvarsCounter = 0;
        MineralCollecter.Instance.yesimcounter= 0;
        */
        yield return new WaitForSeconds(0.8f);
   //     SceneManager.LoadScene(1);
    }
    
}
