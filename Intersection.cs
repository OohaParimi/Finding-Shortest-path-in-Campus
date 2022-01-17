// ********************************************************************************
// Course: CSCI 651
// Instructor: Hou
//
// Programmers: Adam Guidarini, Ooha Parimi, Daniel Widing
// Z-IDs:       Z-1891236     , Z-1911845  , Z-1838064
//
// Project: Term Final Project
//
// File: Intersection.cs
// Purpose: Construct a new Intersection where 2 or more paths meet.
// Notes: For consistency, all IDs should be 4 characters long starting with "I"
// followed by 3 numbers. EX: I010, I000, I999
// ********************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

namespace guidarini_parimi_widing_651TermProject
{
    class Intersection : Vertex
    {
        public Intersection(string id, double x, double y)
        {
            ID = id;
            coordinants = new Tuple<double, double>(x, y);
        }
    }
}
