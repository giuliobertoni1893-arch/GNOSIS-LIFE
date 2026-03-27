using UnityEngine;

public static class Drawing
{
    static Texture2D lineTex;

    public static void DrawLine(Vector2 p1, Vector2 p2, Color color, float width)
    {
        if (!lineTex)
        {
            lineTex = new Texture2D(1, 1);
            lineTex.SetPixel(0, 0, Color.white);
            lineTex.Apply();
        }

        Matrix4x4 matrix = GUI.matrix;

        float angle = Vector3.Angle(p2 - p1, Vector2.right);
        if (p1.y > p2.y) angle = -angle;

        GUIUtility.RotateAroundPivot(angle, p1);
        GUI.color = color;

        GUI.DrawTexture(new Rect(p1.x, p1.y, (p2 - p1).magnitude, width), lineTex);

        GUI.matrix = matrix;
    }
}