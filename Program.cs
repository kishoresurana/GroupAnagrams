using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
           var res = (new Solution()).GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
           foreach (var lst in res){
               Console.WriteLine(string.Join(' ', lst));
           }
        }
    }

    public class Solution {
        public IList<IList<string>> GroupAnagrams(string[] strs) {
            var res = new List<IList<string>>();
            var grp = new Dictionary<string, IList<string>>();
            
            // for each word
            foreach(var str in strs){
                // get the root word
                var rt = String.Concat(str.OrderBy(ch => ch));
                
                if (grp.ContainsKey(rt)){
                    grp[rt].Add(str);
                } else {
                    grp[rt] = new List<string>() { str };
                }
            }
            
            foreach(var key in grp.Keys){
                res.Add(grp[key]);
            }
            return res;
        }
    }
}