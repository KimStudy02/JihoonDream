using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int             wayPointCount;
    public Transform[]     wayPoints;
    public int             currentIndex = 0;
    public Movement2D      movement2D;

    public void Setup(Transform[] wayPoints)
    {
        movement2D          = GetComponent<Movement2D>();

        wayPointCount       = wayPoints.Length;
        this.wayPoints      = new Transform[wayPointCount];
        this.wayPoints      = wayPoints;

        transform.position = wayPoints[currentIndex].position;

        NextMoveTo();
        //StartCoroutine(OnMove());
    }

    void Update()
    {
        

        if (Vector3.Distance(transform.position, wayPoints[currentIndex].position) <= Time.deltaTime * movement2D.MoveSpeed)
        {
            NextMoveTo();
        }

        transform.Rotate(Vector3.forward * 10);

        if (Vector3.Distance(transform.position, wayPoints[currentIndex].position) <= Time.deltaTime * movement2D.MoveSpeed)
        {
            NextMoveTo();
        }
    }

    private void NextMoveTo()
    {
        if(currentIndex < wayPointCount - 1)
        {
            transform.position = wayPoints[currentIndex].position;

            currentIndex++;
            Vector3 direction = (wayPoints[currentIndex].position - transform.position).normalized;
            movement2D.MoveTo(direction);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
