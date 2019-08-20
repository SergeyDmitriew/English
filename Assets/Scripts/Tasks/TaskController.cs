using System.Collections.Generic;
using UnityEngine;

using Random = System.Random;

namespace Core.Task
{
    public enum ETaskResult
    {
        True,
        False,
        Exclude
    }

    public class Task : ITask
    {
        public string Question { get; private set; }
        public string Answer { get; private set; }

        public void Set(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }
    }

    public class Node
    {
        public string WordA;
        public string WordB;

        public Node(string wordA, string wordB)
        {
            WordA = wordA;
            WordB = wordB;
        }
    }

    public class TaskController : ITaskController
    {
        private readonly List<Node> _nodes;
        private readonly Random _random;
        private readonly Task _task;

        public ITask Task { get { return _task; } }

        public TaskController()
        {
            var asset = Resources.Load<TextAsset>("Data");
            _nodes = Parse(asset.text);

            _random = new Random();
            _task = new Task();
        }

        private List<Node> Parse(string text)
        {
            string[] lines = text.Split('\n');
            var nodes = new List<Node>(lines.Length);

            foreach (string item in lines)
            {
                var words = item.Split('\t');
                if (words.Length == 2)
                    nodes.Add(new Node(words[0], words[1]));
            }

            return nodes;
        }

        private int startIndex;
        private int limit = 20;

        public void Next()
        {
            int currect = (startIndex + _random.Next() % limit) % _nodes.Count;
            var node = _nodes[currect];

            _task.Set(node.WordB, node.WordA);
        }

        public void Mark(ETaskResult result)
        {

        }
    }
}