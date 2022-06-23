using UnityEngine;

public static class ColorEx
{
    public static Color WithR(this Color c, float r)
    {
        c.r = r;
        return c;
    }

    public static Color WithG(this Color c, float g)
    {
        c.g = g;
        return c;
    }

    public static Color WithB(this Color c, float b)
    {
        c.b = b;
        return c;
    }

    public static Color WithA(this Color c, float a)
    {
        c.a = a;
        return c;
    }


    public static Color32 WithR(this Color32 c, byte r)
    {
        c.r = r;
        return c;
    }

    public static Color32 WithG(this Color32 c, byte g)
    {
        c.g = g;
        return c;
    }

    public static Color32 WithB(this Color32 c, byte b)
    {
        c.b = b;
        return c;
    }

    public static Color32 WithA(this Color32 c, byte a)
    {
        c.a = a;
        return c;
    }
}
