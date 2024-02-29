using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHide : MonoBehaviour
{
    public GameObject hide;
    public GameObject show;

    public void Hide() { hide.SetActive(false);}   
    public void Show() { show.SetActive(false); }


}
