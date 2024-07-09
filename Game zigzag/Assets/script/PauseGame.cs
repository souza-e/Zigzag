using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
  // Start is called before the first frame update

  [SerializeField]

  private Text txtpause;



  public void pause()
  {

    if (Time.timeScale == 1)
    {
      Time.timeScale = 0;
      txtpause.enabled = true;
    }
    else
    {
      Time.timeScale = 1;
      txtpause.enabled = false;
    }
  }
}
