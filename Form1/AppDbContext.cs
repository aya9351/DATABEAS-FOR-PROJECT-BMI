//using final_Project.Data;
//using final_Project.Models;
using System;

namespace final_Project
{
    internal class AppDbContext : IDisposable
    {
        public object Measurements { get; internal set; }
    }
}