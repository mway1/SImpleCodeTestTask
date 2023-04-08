using System.Collections.Generic;

public class Solution
{
    public static int[] solution(string[] A, string[] B)
    {
        HashSet<string> forbidden = new HashSet<string>(B); // хэш-сет запрещенных хостов
        HashSet<string> allowed = new HashSet<string>(); // хэш-сет доступных хостов
        Queue<string> queue = new Queue<string>(); // очередь доступных хостов

        foreach (string host in A)
        { 
            if (forbidden.Contains(host)) continue; 

            bool isAllowed = true;

            for (int i = host.Length - 1; i >= 0; i--)
            { 
                if (host[i] == '.')
                { 
                    string parent = host.Substring(0, i); 

                    if (forbidden.Contains(parent))
                    { 
                        isAllowed = false; 
                        break; 
                    }
                }
            }

            if (isAllowed)
            { 
                allowed.Add(host); 
                queue.Enqueue(host); 
            }
        }

        int[] result = new int[queue.Count];
        int index = 0;

        while (queue.Count > 0)
        {
            string host = queue.Dequeue();
            result[index++] = Array.IndexOf(A, host);
        }

        return result;
    }
}