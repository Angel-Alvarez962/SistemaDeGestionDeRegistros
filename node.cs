using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRegistro
{
    class Node
    {
        private int? data; // Dato que guarda el nodo
        public Student student;
        private Node left; // Nodo siguiente a la izquierda
        private Node right; // Nodo siguiente a la derecha

        // Constructores de la clase Node
        public Node(int data, Node left, Node right, Student student)
        {
            this.data = data;
            this.left = left;
            this.right = right;
            this.student = student;
        }

        public Node(int data, Student student)
        {
            this.data = data;
            left = null;
            right = null;
            this.student = student;
        }

        public Node(int data)
        {
            this.data = data;
            left = null;
            right = null;
            this.student = null;
        }


        public Node()
        {
            data = null;
            left = null;
            right = null;
            student = null;
        }

        // Getters y setters de la clase Node
        public int? Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node Left
        {
            get { return left; }
            set { left = value; }
        }

        public Node Right
        {
            get { return right; }
            set { right = value; }
        }
    }
}