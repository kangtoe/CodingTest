using System;

public class Sol {
    
    static void Main(string[] args)
    {
        int cnt = 0;
        int pos = 1;
        
        string [] tmp = Console.ReadLine().Split();
        int n = int.Parse(tmp[0]);
        int m = int.Parse(tmp[1]);
        
        int j = int.Parse(Console.ReadLine());
        for(int i = 0; i < j; i++)
        {
            int drop = int.Parse(Console.ReadLine());
            
            if(drop < pos)
            {
                cnt += (pos - drop);
                pos = drop;
            }
            else if(pos + m <= drop)
            {
                cnt += drop - (pos + m - 1);
                pos = drop - m + 1;
            }
        }
        
        Console.WriteLine(cnt);
    }
}