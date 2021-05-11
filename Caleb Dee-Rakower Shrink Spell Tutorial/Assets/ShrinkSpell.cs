using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkSpell : MonoBehaviour
{
  public GameObject theBison;
  public bool spellWorking = false;
  public GameObject MagicStars;



    // Update is called once per frame
    void Update()
    {
    if (spellWorking ==  true)
    {
      MagicStars.SetActive(true);

    }
    if (theBison.transform.localScale.y >=0.33)
    {
      theBison.transform.localScale -= new Vector3(0.001f,0.001f,0.001f);
    }
    else
    {
      spellWorking = false;
    }
    }
}
