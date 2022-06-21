
using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour
{
    //Trigger scoring zones
    public EventTrigger.TriggerEvent scoreTrigger;

    //Update score according to zones when scored
    private void OnCollisionEnter2D(Collision2D other) {

        Ball ball = other.gameObject.GetComponent<Ball>();

        if (ball) {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(eventData);
        }
    }
}
