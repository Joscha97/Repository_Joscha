using System;
using System.Linq;
using System.Collections.Generic;

namespace Aufgabe4
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new TreeNode<String>();
            var root = tree.CreateNode("root");
            var child1 = tree.CreateNode("child1");
            var child2 = tree.CreateNode("child1");
            root.AppendChild(child1);
            root.AppendChild(child2);
            var grand11 = tree.CreateNode("grand11");
            var grand12 = tree.CreateNode("grand12");
            var grand13 = tree.CreateNode("grand13");
            child1.AppendChild(grand11);
            child1.AppendChild(grand12);
            child1.AppendChild(grand13);
            var grand21 = tree.CreateNode("grand21");
            child2.AppendChild(grand21);
            child1.RemoveChild(grand12);

            root.PrintTree(); 
        }
        public class TreeNode<T>
        {
            public T Daten;
            public List<TreeNode<T>> Children = new List<TreeNode<T>>();

            public TreeNode<T> CreateNode(T daten)
            {
                TreeNode<T> newNode = new TreeNode<T>
                {
                    Daten = daten
                };
                return newNode;
            }

            public void AppendChild(TreeNode<T> child)
            {
                Children.Add(child);
            }

            public void RemoveChild(TreeNode<T> child)
            {
                Children.Remove(child);
            }

            public void PrintTree(String AddTree = "")
            {
                Console.WriteLine(AddTree + Daten);
                foreach (TreeNode<T> child in Children)
                {
                    child.PrintTree(AddTree + "*");
                }
            }
        }
    }
}
