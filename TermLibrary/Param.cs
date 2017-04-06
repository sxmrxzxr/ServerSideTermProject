using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermLibrary
{
    class Param
    {
        private string paramName;
        private object paramVal;
        private SqlDbType paramType;

        public Param(string n, object v, SqlDbType t)
        {
            this.paramName = n;
            this.paramVal = v;
            this.paramType = t;
        }
    }
}
