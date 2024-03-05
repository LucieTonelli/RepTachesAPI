//using EnvDTE;
//using System;
//using System.Collections.Generic;
//using System.Data.SqlTypes;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Tools.Tools
//{
//    public object ToSafeDbDateDBnull(this object objectstring)
//    {
//        try
//        {
//            if ((DateTime)objectstring >= SqlDateTime.MinValue)
//            {
//                return objectstring;
//            }
//            else
//            {
//                return DBNull.Value;
//            }
//        }
//        catch (Exception)
//        {

//            return DBNull.Value;
//        }

//    }

//    private DateTime objdte = new(1000, 1, 1);
//    DTE.ToSafeDbDateDBnull();
//}
