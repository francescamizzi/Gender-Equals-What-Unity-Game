using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnapController : MonoBehaviour
{
    public List<Transform> snapPoints;
    public List<Draggable> draggableObjects;
    public float snapRange = 10f;
    int counter = 0;

    public gymTextBox textBox;

    // Start is called before the first frame update
    void Start()
    {
        foreach(Draggable draggable in draggableObjects)
        {
            draggable.dragEndedCallback = OnDragEnded;
        }
    }

    private void OnDragEnded(Draggable draggable)
    {
        float closestDistance = -1;
        Transform closestSnapPoint = null;

        foreach(Transform snapPoint in snapPoints)
        {
            float currentDistance = Vector2.Distance(draggable.transform.localPosition, snapPoint.localPosition);
            if(closestSnapPoint == null || currentDistance < closestDistance)
            {
                closestSnapPoint = snapPoint;
                closestDistance = currentDistance;
            }
        }

        if(closestSnapPoint !=null && closestDistance <= snapRange)
        {
            draggable.transform.localPosition = closestSnapPoint.localPosition;

            counter ++;
            Debug.Log(counter);
        }

        if(counter == 4)
        {
            Debug.Log("Round Won");
            nextScene();
        }
    } 

    public void nextScene()
    {
        SceneManager.UnloadSceneAsync("WashingClothes");
        textBox = GameObject.FindObjectOfType(typeof(gymTextBox)) as gymTextBox;
        textBox.ToggleBox();
    }
}
