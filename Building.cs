// ********************************************************************************
// Course: CSCI 651
// Instructor: Hou
//
// Programmers: Adam Guidarini, Ooha Parimi, Daniel Widing
// Z-IDs:       Z-1891236     , Z-1911845  , Z-1838064
//
// Project: Term Final Project
//
// File: Building.cs
// Purpose: Create a new Building
// Notes: For consistency, all IDs should be 4 characters long starting with "B"
// followed by 3 numbers. EX: B010, B000, B999
// ********************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

namespace guidarini_parimi_widing_651TermProject
{
    class Building : Vertex
    {
        string name;
        string address;
        
        public Building (string vertexId, string buildingName, string add, double x, double y)
        {
            ID = vertexId;
            name = buildingName;
            address = add;
            coordinants = new Tuple<double, double>(x, y);

        }

        public string GetName() => name;
        public string getAddress() => address;
    }
}
