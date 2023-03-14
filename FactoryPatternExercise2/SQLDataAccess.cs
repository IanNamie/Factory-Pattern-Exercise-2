﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
     public class SQLDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from a SQL Database");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a SQL Database");
        }
    }
}
