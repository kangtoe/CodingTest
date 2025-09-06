using System;
using System.Collections.Generic;
class HelloWorld {
    
  static int Cmp(List<int> a, List<int> b){
      
    int freq = b[1] - a[1];
    if(freq!=0) return freq;
    return a[2] - b[2];
  }
    
  static void Main() {
    
    SortedDictionary<int,int> mp, mp_first = new SortedDictionary<int,int>();
    
    string[] str = Console.ReadLine().Split();
    int n = int.Parse(str[0]);
    int c = int.Parse(str[1]);
    
    int[] arr = new int[n];
    string[] nums = Console.ReadLine().Split();
    
    Dictionary<int,int> freqDict = new Dictionary<int,int>();
    Dictionary<int,int> orderDict = new Dictionary<int,int>();
    
    for(int i = 0; i< n; i++)
    {
        arr[i] = int.Parse(nums[i]);
        
        if(freqDict.ContainsKey(arr[i]))
            freqDict[arr[i]]++;
        else
        {
            freqDict[arr[i]] = 1;
            orderDict[arr[i]] = i;
        }
    }
    
    List<List<int>> li = new List<List<int>>();
    foreach(var kv in  freqDict)
    {
        int k = kv.Key;
        int v = kv.Value;
        int o = orderDict[k];
        li.Add(new List<int>(){k,v,o});
    }
    
    li.Sort(Cmp);
    
    foreach(List<int> l in li)
    {
        for(int i = 0; i< l[1]; i++)
        {
            Console.Write(l[0] + " ");
        }
        
    }
  }
}