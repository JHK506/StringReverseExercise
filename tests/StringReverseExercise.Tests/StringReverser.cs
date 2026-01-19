using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StringReverseExercise.Tests
{
    public class StringReverser
    {
        public string Exercise1(string s)
        {
            var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            return string.Join(" ", words);
        }
        public string Exercise2(string s2)
        {
            var words = s2.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                char[] chars = words[i].ToCharArray();
                Array.Reverse(chars);
                words[i] = new string(chars);
            }
            return string.Join(" ", words);
        }
        public string Exercise31(string s31) 
        {
            var words = s31.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                char[] chars = words[i].ToCharArray();
                Array.Reverse(chars);
                for (int j = 0; j < chars.Length; j++)
                    chars[j] = char.IsUpper(chars[j]) ? char.ToLower(chars[j]) : char.ToUpper(chars[j]);
                
                    words[i] = new string(chars);
            }
            return string.Join(" ", words);
        }
        public string Exercise32(string s32)
        {
            var words = s32.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                char[] chars = words[i].ToCharArray();
                Array.Reverse(chars);
                words[i] = new string(chars);
            }
            for (int j = 0; j < words.Length; j++)            
                if (!string.IsNullOrEmpty(words[j]))
                    words[j] = char.ToUpper(words[j][0]) + words[j].Substring(1).ToLower();                
            
            return string.Join(" ", words);
        }
        public string Exercise33(string s33)
        {
            bool upperCase = true;
            var words = s33.Split(' ', StringSplitOptions.None);
            for (int i = 0; i < words.Length; i++)
                words[i] = new string(words[i].Reverse().ToArray());
            
            var chars = string.Join(" ", words).ToLower().ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (upperCase && char.IsLetter(chars[i]))                
                    chars[i] = char.ToUpper(chars[i]);
                    upperCase = false;
                
                if (chars[i] is '.' or '!' or '?')
                    upperCase = true;
            }
            return new string(chars);
        }
    }
}
