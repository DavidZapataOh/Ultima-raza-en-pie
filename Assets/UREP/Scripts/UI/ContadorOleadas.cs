using MoreMountains.Tools;
using MoreMountains.TopDownEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorOleadas : MonoBehaviour, MMEventListener<MMGameEvent>
{
    [SerializeField]
    private TMP_Text texto;

    public void OnMMEvent(MMGameEvent eventType){
        if(eventType.EventName == "NuevaOla"){
            int ola_actual = Oleadas.Instance.OlaActual;
            int cantidad_olas = Oleadas.Instance.CantidadOlas();
            texto.text = "Oleada #" + ola_actual;
        }
    }

    void OnEnable(){
        this.MMEventStartListening<MMGameEvent>();
    }

    void OnDisable(){
        this.MMEventStopListening<MMGameEvent>();
    }
}
