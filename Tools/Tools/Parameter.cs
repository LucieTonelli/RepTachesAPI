using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepTachesAPI.DAL.Tools
{
    public class Parameter
    {

            internal object Value { get; private set; }
            internal ParameterDirection Direction { get; private set; }

            internal Parameter(object value, ParameterDirection direction)
            {
                Value = value;
                Direction = direction;
            }
        
    }


}

