﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp74
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = null;
            Node BinSearchTree = new Node();

            int size = 20;
            int[] a = new int[size];

            Random rand = new Random();

            for (int i = 0; i < size; i++)
                a[i] = rand.Next(100);

           // for (int i = 0; i < size; i++)
           //     root = BinSearchTree.Add(root, a[i]);


                

        }

        class Node
        {
            private int value;
            public Node Left { get; private set; }
            public Node Right { get; private set; }


            public Node(int value)
            {
                this.value = value;
                Left = null;
                Right = null;
            }
            public void Add(int newValue)
            {
                Node NewNode = new Node(newValue);
                if (newValue < this.value)
                {
                    if (Left == null)
                        Left = new Node(newValue);
                    else
                        Left.Add(newValue);
                }
                else if (newValue > this.value)
                {
                    if (Right == null)
                        Right = new Node(newValue);
                    else
                        Right.Add(newValue);
                }

            }
            public List<int> GetList(List<int> answer)
            {
                Left?.GetList(answer);
                answer.Add(value);
                Right?.GetList(answer);
                return answer;
            }
            public override string ToString()=>string.Join(",", GetList(new List<int>()));

        }
   

    }

}
