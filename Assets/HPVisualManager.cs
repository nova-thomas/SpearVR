using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HPVisualManager : MonoBehaviour
{
    public int MaxHealth = 5;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = 5;
       
    }



 

    public void takeDamage(){
        if(count<MaxHealth){
            this.gameObject.transform.GetChild(count).gameObject.SetActive(false);
            count+=1;
        } else {
            Debug.Log("die");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Application.LoadLevel(1);
        }
    }

    public void healDamage(){
        if(count!=0){
        count-=1;
        this.gameObject.transform.GetChild(count).gameObject.SetActive(true);
        }


  
    }



}