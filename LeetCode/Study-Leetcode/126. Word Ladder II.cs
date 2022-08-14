using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Study_Leetcode
{
    internal class _126
    {
        /// <summary>
        /// Runtime: 359 ms, faster than 10.87% of C# online submissions for Word Ladder II.
        /// Memory Usage: 46.8 MB, less than 31.52% of C# online submissions for Word Ladder II.
        /// </summary>
        Dictionary<string, List<string>> adjList = new Dictionary<string, List<string>>();
        List<string> currPath = new List<string>();
        List<IList<string>> shortestPaths = new List<IList<string>>();
        public List<string> FindNeighbors(string word, HashSet<string> wordList)
        {
            var neighbors = new List<string>();
            var charList = word.ToCharArray();
            for (int i = 0; i < word.Count(); i++)
            {
                char oldChar = charList[i];
                for (char c = 'a'; c <= 'z'; c++)
                {
                    charList[i] = c;
                    if (c == oldChar || !wordList.Contains(new string(charList)))
                    {
                        continue;
                    }
                    neighbors.Add(new string(charList));
                }
                charList[i] = oldChar;
            }
            return neighbors;
        }
        private void Backtrack(string source, string destination)
        {
            if (source.Equals(destination))
            {
                var tempPath = new List<string>(currPath);
                tempPath.Reverse();
                shortestPaths.Add(tempPath);
            }
            if (!adjList.ContainsKey(source))
            {
                return;
            }
            for (int i = 0; i < adjList[source].Count(); i++)
            {
                currPath.Add(adjList[source][i]);
                Backtrack(adjList[source][i], destination);
                currPath.RemoveAt(currPath.Count() - 1);
            }
        }
        public void BFS(string beginWord, string endWord, HashSet<string> wordList)
        {
            var q = new Queue<string>();
            q.Enqueue(beginWord);
            if (wordList.Contains(beginWord))
            {
                wordList.Remove(beginWord);
            }
            var isEnqueued = new Dictionary<string, int>();
            isEnqueued.Add(beginWord, 1);
            while (q.Count() > 0)
            {
                var visited = new List<string>();
                for (int i = q.Count() - 1; i >= 0; i--)
                {
                    var currWord = q.Dequeue();
                    var neighbors = FindNeighbors(currWord, wordList);
                    foreach (var word in neighbors)
                    {
                        visited.Add(word);

                        if (!adjList.ContainsKey(word))
                        {
                            adjList.Add(word, new List<string>());
                        }
                        adjList[word].Add(currWord);
                        if (!isEnqueued.ContainsKey(word))
                        {
                            q.Enqueue(word);
                            isEnqueued.Add(word, 1);
                        }
                    }
                }
                for (int i = 0; i < visited.Count(); i++)
                {
                    if (wordList.Contains(visited[i]))
                    {
                        wordList.Remove(visited[i]);
                    }
                }
            }
        }
        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            var copiedWordList = new HashSet<string>(wordList);
            BFS(beginWord, endWord, copiedWordList);
            currPath.Add(endWord);
            Backtrack(endWord, beginWord);
            return shortestPaths;
        }
    }
}
