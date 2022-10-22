using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public GameObject gameOverPanel;


    void Start()
    {
        gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(GlobalData.shinyCount == 0)
        {
            if(!(craftItem.checkMats("widget", 1)) & !(craftItem.checkMats("gidget",1)) & !(craftItem.checkMats("doodad", 1)) & !(craftItem.checkMats("whizbang", 1)) & !(craftItem.checkMats("whatzit", 1)) & !(craftItem.checkMats("thingamajig", 1)) & !(craftItem.checkMats("gizmo", 1)) & !(craftItem.checkMats("gadget", 1)))
            {
                
                if(!craftItem.checkMats("sprocket", 2))
                {
                    
                    if(!(craftItem.checkMats("spring", 1)))
                    {
                        if (!(craftItem.checkMats("rod", 2)))
                        {
                            gameOverPanel.SetActive(true);
                        }
                    }
                    else if(!(craftItem.checkMats("gear", 1)))
                    {
                        if(!(craftItem.checkMats("rod", 1)))
                        {
                            gameOverPanel.SetActive(true);
                        }
                        else if(!(craftItem.checkMats("plate", 1)))
                        {
                            gameOverPanel.SetActive(true);
                        }
                    }
                    
                }
                else if(!craftItem.checkMats("lever", 1))
                {
                    
                    if(!craftItem.checkMats("rod", 1))
                    {
                        gameOverPanel.SetActive(true);
                    }
                    else if(!craftItem.checkMats("gear", 1))
                    {
                        if(!craftItem.checkMats("rod", 1))
                        {
                            gameOverPanel.SetActive(true);
                        }
                        else if(!craftItem.checkMats("plate", 1))
                        {
                            gameOverPanel.SetActive(true);
                        }
                    }
                }
                
                
            }
        }
    }

    public void restart()
    {
        SceneManager.LoadScene("MainScene");
        gameOverPanel.SetActive(false);
    }
}
    
