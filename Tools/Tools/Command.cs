using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace RepTachesAPI.DAL.Tools
{
    public class Command
    {
        internal string Query { get; private set; }
        internal bool IsStoredProcedure { get; private set; }
        internal IDictionary<string, Parameter> Parameters { get; private set; }

        public Command(string query, bool isStoredProcedure = false)
        {
            Query = query;
            IsStoredProcedure = isStoredProcedure;
            Parameters = new Dictionary<string, Parameter>();
        }

        public void AddParameter(string parameterName, object value, ParameterDirection parameterDirection = ParameterDirection.Input)
        {
            Parameters.Add(parameterName, new Parameter(value ?? DBNull.Value, parameterDirection));
        }
    }
}
