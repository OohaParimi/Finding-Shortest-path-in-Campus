// ********************************************************************************
// Course: CSCI 651
// Instructor: Hou
//
// Programmers: Adam Guidarini, Ooha Parimi, Daniel Widing
// Z-IDs:       Z-1891236     , Z-1911845  , Z-1838064
//
// Project: Term Final Project
//
// File: Edge.cs
// Purpose: Creates an edge connecting to vertices. Each vertex ID is passed to
// to the end points of the edge.
// Notes: For consistency, all IDs should be 4 characters long starting with "E"
// followed by 3 numbers. EX: E010, E000, E999
// ********************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

namespace guidarini_parimi_widing_651TermProject
{
    class Edge
    {
        private string id;
        private int weight;
        private Tuple<object, object> vertices;

        public Edge (string edgeId, int edgeWeight, object end1, object end2)
        {
            id = edgeId;
            weight = edgeWeight;
            vertices = new Tuple<object, object>(end1, end2);
        }

        public string GetId() => id;
        public int GetWeight() => weight;
        public Tuple<object, object> Vertices => vertices;
    }
}
