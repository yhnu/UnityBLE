using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMgr : MonoBehaviour
{
    public GameObject MainUI;
    public GameObject PlotUI;

    public void OnClickPlotButton()
    {
        MainUI?.SetActive(false);
        PlotUI?.SetActive(true);
    }

    public void OnClickNumberButton()
    {
        MainUI?.SetActive(true);
        PlotUI?.SetActive(false);
    }
}
