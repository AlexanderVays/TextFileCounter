using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextFileCounter.Forms;

namespace TextFileCounter
{
    class Reader
    {
        public static Dictionary<string, int> resultDictionary = new Dictionary<string, int>();

        public static void GetWordsCount(List<string> strList, bool caseSensitive) 
        {
            List<string> myList = new List<string>();
            string contents = File.ReadAllText(MainForm.fileName);
            foreach (string str in strList)
            {
                if (caseSensitive)
                {
                    var matches = Regex.Matches(contents, @"\b" + str + @"\b"); //collection of matches
                    if (!resultDictionary.ContainsKey(str))
                    {
                        int count = matches.Count > 0 ? matches.Count : 0;
                        resultDictionary.Add(str, count);
                    }

                    /*
                    foreach (KeyValuePair<string, int> entry in resultDictionary)
                    {
                        Console.WriteLine($"The word ({entry.Key}) appeared in text {entry.Value} times");
                    }
                    */
                }
                else
                {
                    string contentsLowerCase = contents.ToLower();
                    var matches = Regex.Matches(contentsLowerCase, @"\b" + str.ToLower() + @"\b"); //collection of matches
                    if (!resultDictionary.ContainsKey(str))
                    {
                        int count = matches.Count > 0 ? matches.Count : 0;
                        resultDictionary.Add(str, count);
                    }

                    /*
                    foreach (KeyValuePair<string, int> entry in resultDictionary)
                    {
                        Console.WriteLine($"The word ({entry.Key}) appeared in text {entry.Value} times");
                    } */
                }
            }
        }


        public static void GetPhrasesCount(List<string> strList, bool caseSensitive)
        {
            List<string> myList = new List<string>();
            string contents = File.ReadAllText(MainForm.fileName);
            foreach (string str in strList)
            {
                if (caseSensitive)
                {
                    string pattern = $@"\s{str}\s";  //regex pattern
                    Regex regex = new Regex(pattern); //creates new regex with a specific pattern
                    var matches = regex.Matches(contents); //collection of matches
                    if (!resultDictionary.ContainsKey(str))
                    {
                        int count = matches.Count > 0 ? matches.Count : 0;
                        resultDictionary.Add(str, count);
                    }

                    /*
                    foreach (KeyValuePair<string, int> entry in resultDictionary)
                    {
                        Console.WriteLine($"The word ({entry.Key}) appeared in text {entry.Value} times");
                    }
                    */
                }
                else
                {
                    string contentsLowerCase = contents.ToLower();
                    var matches = Regex.Matches(contentsLowerCase, @"\s" + str.ToLower() + @"\s"); //collection of matches
                    if (!resultDictionary.ContainsKey(str))
                    {
                        int count = matches.Count > 0 ? matches.Count : 0;
                        resultDictionary.Add(str, count);
                    }

                    /*
                    foreach (KeyValuePair<string, int> entry in resultDictionary)
                    {
                        Console.WriteLine($"The word ({entry.Key}) appeared in text {entry.Value} times");
                    } */
                }
            }
        }
    }
}
