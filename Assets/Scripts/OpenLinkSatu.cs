using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenLinkSatu : MonoBehaviour
{
  

    public void OpenLinkMethod(string url)
    {
        Application.OpenURL(url);
    }
}
