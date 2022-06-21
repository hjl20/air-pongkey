
using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour
{
    //Set up trigger for scoring zones
    public EventTrigger.TriggerEvent scoreTrigger;

    private void OnCollisionEnter2D(Collision2D other) {

        Ball ball = other.gameObject.GetComponent<Ball>();

        //Calls scoring function if collision object is ball
        if (ball) {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(eventData);
        }
    }
    
}
