using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpCode
{
    public class CarpCode
    {
        public void App(string data)
        {
            string[] cmds = { "keyencode", "rndencode", "decode", "keyencode+" };
            if (data.ToLower().Contains(cmds[0]) && !data.ToLower().Contains(cmds[3]))
            {
                data = data.Substring(cmds[0].Length + 1);
                Console.WriteLine(EncodeWithKey(data.Substring(0, data.IndexOf(' ')), data.Substring(data.IndexOf(' ') + 1)));
            }
            else if (data.ToLower().Contains(cmds[1]))
            {
                data = data.Substring(cmds[1].Length + 1);
                string key = RNDKey(data);
                Console.WriteLine("Result: {0}, Code: {1}, Key: {2}", EncodeWithKey(data, key), data, key);
            }
            else if (data.ToLower().Contains(cmds[3]))
            {
                data = data.Substring(cmds[3].Length + 1);
                string result = EncodeWithKey(data.Substring(0, data.IndexOf(' ')), data.Substring(data.IndexOf(' ') + 1));
                Clipboard.SetText(result);
                Console.WriteLine(Clipboard.GetText());
            }
            else
            {
                Console.WriteLine("Invalid Command!");
            }

        }
        public string EncodeWithKey(string data, string key)
        {
            key = key.ToLower();
            char[] lowAlphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g',
                'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            int[] basicNumbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22,
            23, 24, 25, 26};
            string result = "";
            if (data.Length != key.Length)
            {
                return "The key's length must match the code's length!";
            }
            else
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == 't')
                    {
                        result += data[i];
                    }
                    else if (key[i] == 'a')
                    {
                        result += (int)data[i];
                    }
                    else if (key[i] == 'b')
                    {
                        if (GetIndexByValue(lowAlphabet, data.ToLower()[i]) == -1)
                        {
                            return string.Format("INVALID LETTER: {0}", data[i]);
                        }
                        if (GetIndexByValue(lowAlphabet, data.ToLower()[i]) != -1)
                        {
                            result += basicNumbers[GetIndexByValue(lowAlphabet, data.ToLower()[i])];
                        }
                        else
                        {
                            result += data[i];
                        }
                    }
                    else
                    {
                        return "INVALID KEY!";
                    }
                }
                return result;
            }
        }
        public int GetIndexByValue(char[] arr, char value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        public string RNDKey(string code)
        {
            string key = "";
            char[] types = { 't', 'a', 'b' };
            Random rnd = new Random();
            for (int i = 0; i < code.Length; i++)
            {
                key += types[rnd.Next(0, 3)];
            }
            return key;
        }
        /*public string Decode(string code, string key)
        {
            key = key.ToLower();
            string result = "";
            for (int i = 0; i < key.Length; i++)
            {
                if (key[i] == 't')
                {
                    result += code[0];
                    code = code.Substring(1);
                }
                else if (key[i] == 'a')
                {
                    if (code[0] == '1')
                    {
                        result += code.Substring(0, 3);
                        code = code.Substring(4);
                    }
                    else
                    {
                        result += code.Substring(0, 2);
                        code = code.Substring(3);
                    }
                }
                else if (key[i] == 'b')
                {
                    
                }
            }
            return result;
        }*/
    }
}
