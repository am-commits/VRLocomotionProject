using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class PlayAreaRectangle : MonoBehaviour
{
	public int counter = 0;
	public GameObject[] trees;
	public GameObject bush;
	public GameObject butterfly;
	
    void Start()
	{
		Vector3[] boundaryPoints = OVRManager.boundary.GetGeometry(OVRBoundary.BoundaryType.OuterBoundary);

		foreach (Vector3 pos in boundaryPoints)
            {  
				counter++;
				if (counter % 20 == 0) {
					Instantiate(trees[Random.Range(0,trees.Length)], pos, Quaternion.identity);
				}
				if (counter % 20 == 0) {
					Instantiate(bush, pos, Quaternion.identity);
				}
				if (counter % 20 == 0) {
					Instantiate(trees[Random.Range(0,trees.Length)], pos*2.5f, Quaternion.identity);
				}
				if (counter % 15 == 0) {
					Instantiate(trees[Random.Range(0,trees.Length)], pos*2f, Quaternion.identity);
				}

		}
	Instantiate(butterfly, boundaryPoints[Random.Range(0,boundaryPoints.Length)]*0.7f + new Vector3(0, Random.Range(1,3), 0), Quaternion.identity);																		   			
	}																																								
}

