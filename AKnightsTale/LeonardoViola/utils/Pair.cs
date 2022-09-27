namespace AKnightsTale.Leonardo_Viola.utils;

public class Pair <TK, TV>
{
    public Pair(TK k, TV v)
    {
        K = k;
        V = v;
    }

    private TK K { get; set; }
    private TV V { get; set; }
}