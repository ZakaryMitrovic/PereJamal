using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candles : MonoBehaviour
{
    [SerializeField] private Candle[] _chandelles;
    public bool SiChandelsAllumer()
    {
        bool isFinish = true;
        foreach (Candle candle in _chandelles)
        {
            if(candle.allumer == false) {
                isFinish = false;
            }
        }
        return(isFinish);
    }
}
