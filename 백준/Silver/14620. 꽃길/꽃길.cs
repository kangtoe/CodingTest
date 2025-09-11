using System;
using System.Collections.Generic;

public class Sol{
    static int n;
    
    static void Comb(int start, int n, int r, List<int> curr, List<List<int>> res)
    {
        if(curr.Count == r)
        {
            res.Add(new List<int>(curr));
            return;
        }
        
        for(int i = start; i < n; i++)
        {
            curr.Add(i);
            Comb(i+1,n,r,curr,res);
            curr.RemoveAt(curr.Count-1);
        }
    }
    
    static void Main()
    {
        n = int.Parse(Console.ReadLine());
        
        int[,] grid = new int[n,n];
        for(int i = 0; i <n;i++)
        {
            string[] str = Console.ReadLine().Split();
            for(int j = 0; j <n;j++)
            {
                grid[i,j] = int.Parse(str[j]);
            }
        }
        
        List<List<int>> res = new List<List<int>>();
        Comb(0,n*n,3,new List<int>(), res);
        
        int minCost = int.MaxValue;
        
        int[] dx = {0,0,0,-1,1};
        int[] dy = {0,1,-1,0,0};
        
        foreach(List<int> li in res)
        {
            int cost = 0;
            int[,] used = new int[n,n];
            bool dead = false;
            
            foreach(int idx in li)
            {
                int y = idx / n;
                int x = idx % n;
                
                for(int i  = 0; i < 5; i++)
                {
                    int ny = y + dy[i];
                    int nx = x + dx[i];
                    
                    if(nx < 0 || ny < 0 || nx >= n || ny >= n || used[ny,nx]!=0)
                    {
                        dead = true;
                        break;
                    }
                    
                    used[ny,nx] = 1;
                    cost += grid[ny,nx];
                }
                
                if(dead) break;
            }
            
            if(dead) continue;
            if(cost<minCost) minCost = cost;
        }
        
        Console.WriteLine(minCost);
    }
}