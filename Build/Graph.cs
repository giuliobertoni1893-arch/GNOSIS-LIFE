using UnityEngine;
using System.Collections.Generic;

public class Graph : MonoBehaviour
{
    public List<int> data;

    void OnGUI()
    {
        if (data == null || data.Count < 2) return;

        for (int i = 1; i < data.Count; i++)
        {
            float x1 = (i - 1) * 5;
            float y1 = 200 - data[i - 1];

            float x2 = i * 5;
            float y2 = 200 - data[i];

            Drawing.DrawLine(new Vector2(x1, y1), new Vector2(x2, y2), Color.white, 2f);
        }
    }
}