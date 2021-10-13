using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour

{
    public GameObject MainmenuPanel;
    public GameObject settingsPanel;
    
    /// <summary>
    /// starts game
    /// </summary>
    public void PlayGame()
 {
     SceneManager.LoadScene(1);
 }
/// <summary>
/// openes settings menu
/// </summary>
 public void Setings()
 {
     MainmenuPanel.SetActive(false);
     settingsPanel.SetActive(true);
 }
/// <summary>
/// exits game
/// </summary>
 public void Exit()
 {
     Application.Quit();
 }
}
