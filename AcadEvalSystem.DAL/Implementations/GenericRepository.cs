using AcadEvalSystem.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcadEvalSystem.DAL.Implementations
{
    internal class GenericRepository<T> : IGenericRepository<T> where T : class
    {
    }
}
