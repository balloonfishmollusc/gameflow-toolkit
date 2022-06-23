using UnityEngine;

public static class VectorEx
{
    public static Vector2 WithX(this Vector2 v, float x)
    {
        v.x = x;
        return v;
    }

    public static Vector2 WithY(this Vector2 v, float y)
    {
        v.y = y;
        return v;
    }

    public static Vector3 WithX(this Vector3 v, float x)
    {
        v.x = x;
        return v;
    }

    public static Vector3 WithY(this Vector3 v, float y)
    {
        v.y = y;
        return v;
    }

    public static Vector3 WithZ(this Vector3 v, float z)
    {
        v.z = z;
        return v;
    }

    public static Vector2Int WithX(this Vector2Int v, int x)
    {
        v.x = x;
        return v;
    }

    public static Vector2Int WithY(this Vector2Int v, int y)
    {
        v.y = y;
        return v;
    }

    public static Vector3Int WithX(this Vector3Int v, int x)
    {
        v.x = x;
        return v;
    }

    public static Vector3Int WithY(this Vector3Int v, int y)
    {
        v.y = y;
        return v;
    }

    public static Vector3Int WithZ(this Vector3Int v, int z)
    {
        v.z = z;
        return v;
    }
}
