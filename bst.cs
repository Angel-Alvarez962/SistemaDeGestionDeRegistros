using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRegistro
{
    class BinaryTree
    {
        private Node root; // Nodo raiz del arbol binario

        // Constructores de la clase BinaryTree
        public BinaryTree()
        {
            root = new Node();
        }

        public BinaryTree(int data)
        {
            root = new Node(data);
        }

        // Metodo que inserta un valor al arbol
        public void Add(int data, Student student)
        {
            // Si el arbol esta vacio agrega el valor como la raiz
            if (root.Data == null)
            {
                root.Data = data;
                root.student = student;
                return;
            }

            Node path = root;
            while (true)
            {
                // Si el valor ya se encuentra en el arbol retorna
                if (data == path.Data) return;

                // Si es mayor a la raiz busca insetarlo en el lado derecho del arbol
                if (data > path.Data)
                {
                    if (path.Right == null)
                    {
                        path.Right = new Node(data, student);
                        return;
                    }
                    path = path.Right;
                }

                // Si es menor a la raiz busca insetarlo en el lado izquierdo del arbol
                else if (data < path.Data)
                {
                    if (path.Left == null)
                    {
                        path.Left = new Node(data, student);
                        return;
                    }
                    path = path.Left;
                }
            }
        }

        // Metodo que imprime el arbol en PreOrden
        private void PreOrder(Node node)
        {
            Console.Write(node.Data + " ");

            if (node.Left != null)
            {
                PreOrder(node.Left);
            }

            if (node.Right != null)
            {
                PreOrder(node.Right);
            }
        }

        public void PreOrder() { PreOrder(root); }

        // Metodo que imprime el arbol en InOrden
        private void InOrder(Node node)
        {
            if (node.Left != null)
            {
                InOrder(node.Left);
            }

            Console.Write(node.Data + " ");

            if (node.Right != null)
            {
                InOrder(node.Right);
            }
        }

        public void InOrder() { InOrder(root); }

        // Metodo que imprime el arbol en PreOrden
        private void PostOrder(Node node)
        {
            if (node.Left != null)
            {
                PostOrder(node.Left);
            }

            if (node.Right != null)
            {
                PostOrder(node.Right);
            }

            Console.Write(node.Data + " ");
        }

        public void PostOrder() { PostOrder(root); }

        public void SearchAndPrint(int value)
        {
            Node result = SearchRecursive(root, value);

            if (result != null)
            {
                Console.WriteLine("Estudiante encontrado: ");

                Console.Write("Alumno: " + result.student.Name + " Matricula: " + result.student.SchoolId + " Promedio: " + result.student.Grade);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("El estudiante no esta en el registro");
            }
        }

        // Private recursive search method
        private Node SearchRecursive(Node node, int value)
        {
            if (node == null || node.Data == null)
                return null;

            if (value == node.Data)
                return node;

            if (value < node.Data)
                return SearchRecursive(node.Left, value);
            else
                return SearchRecursive(node.Right, value);
        }
    }
}