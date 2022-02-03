// ********************************************************************************
// Course: CSCI 651
// Instructor: Hou
//
// Project: Term Final Project
//
// File: Vertex.cs
// Purpose: Super class for Building and Intersection.
// Note: No objects of this class should ever be created, its purpose is to be
// exclusively as a base class for Intersection and Building.
// ********************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

namespace guidarini_parimi_widing_651TermProject
{
    class Vertex
    {
        protected string id;
        protected List<object> neighbors = new List<object>();
        protected Tuple<double, double> coordinants;

        public string ID
        {
            get => id;
            set => id = value;
        }

        public int GetDegree() => neighbors.Count;
        public string GetId() => id;
        public List<object> GetNeighbors() => neighbors;

        public Tuple<double, double> GetCoordinants() => coordinants;

        public void AddNeighbor(object vertex) => neighbors.Add(vertex);

        public void removeNeighbor(string id) => neighbors.Remove(id);
    }
}
