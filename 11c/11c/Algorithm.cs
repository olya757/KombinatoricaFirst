using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11с
{
    public static class Algorithm
    {
        public static List<int> lengths;

        public static int M;

        public static int N;

        public static int P;


        public static bool nextState()
        {
            int j = N - 2;
            while (j != -1 && lengths[j] >= lengths[j + 1]) j--;
            if (j == -1)
                return false; // a - last permutation
            int k = N - 1;
            while (lengths[j] >= lengths[k]) k--;

            int tmp = lengths[j];
            lengths[j] = lengths[k];
            lengths[k] = tmp;

            // reverse back [j+1, n-1]
            int l = j + 1, r = N - 1;
            while (l < r)
            {
                tmp = lengths[l];
                lengths[l] = lengths[r];
                lengths[r] = tmp;
                l++;
                r--;
            }
            return true;
        }

        public static int LEN = 0;

        public static bool CheckForCurrentSide(int len, List<int> vs)
        {
            LEN = len;
            int last = 0;
            int i = 0;
            int cnt = 0;
            while (i < vs.Count && i < P)
            {
                if (last + vs[i] > len) return false;
                if (last + vs[i] == len)
                {
                    cnt++;
                    if (cnt == M) return true;
                    last = 0;
                }
                else
                {
                    last += vs[i];
                }
                i++;
            }
            return false;
        }



        public static bool CheckAllSides(int min, int max)
        {
            do
            {
                for (int i = min; i <= max; i++)
                {
                    if (CheckForCurrentSide(i, lengths)) return true;
                }

            }
            while (nextState());
            for (int i = min; i <= max; i++)
            {
                if (CheckForCurrentSide(i, lengths)) return true;
            }
            return false;
        }

        public static bool FindSides(int m, int p)
        {
            if (p < 3) return false;
            M = m;
            P = p;
            int sum = 0;
            for (int i = 0; i < lengths.Count; i++)
            {
                sum += lengths[i];
            }

            int max = sum / m;
            int min = 1;
            return CheckAllSides(min, max);

        }

        public static bool InputElems(string str)
        {

            string[] ls = str.Split(' ');

            lengths = new List<int>();
            N = 0;
            foreach (var s in ls)
            {
                int n = int.Parse(s);
                if (n <= 0)
                {
                    return false;
                }
                lengths.Add(n);
                N++;
            }
            return N >= 3;
        }


        public static string ShowResultToStr()
        {

            List<List<int>> result = new List<List<int>>();
            int last = 0;
            int cnt = 0;
            List<int> lastres = new List<int>();
            foreach (var i in lengths)
            {
                lastres.Add(i);
                last += i;
                if (last == LEN)
                {

                    last = 0;
                    cnt++;
                    result.Add(lastres);
                    if (cnt == M) break;
                    lastres = new List<int>();
                }
            }

            List<string> vs = new List<string>();
            foreach (var j in result)
            {
                vs.Add(string.Join<int>("+", j));

            }
            return string.Join<string>(", ", vs);
        }


    }
}

