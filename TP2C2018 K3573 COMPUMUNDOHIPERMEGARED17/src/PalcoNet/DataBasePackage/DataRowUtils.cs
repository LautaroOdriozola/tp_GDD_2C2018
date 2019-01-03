﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet
{
    public class DataRowExtended
    {
        private DataRow dr;

        public T At<T>(String columnName)
        {
            return (T)dr[columnName];
        }

        public DataRowExtended(DataRow dr)
        {
            this.dr = dr;
        }


        public Boolean BoolValue(String columnName)
        {
            return Convert.ToBoolean(dr[columnName]);
        }

        public T OrElse<T>(String columnName, T elseValue){
            return dr.IsNull(columnName) ? elseValue : (T)dr[columnName];
        }

        public T Fold<T>(String columnName, T ifNull, Func<Object, T> f)
        {
            try
            {
                return f.Invoke(dr[columnName]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e + "\n" + e.Message + "\n" + e.StackTrace);
                return ifNull;
            }
        }

        public T TryGet<T>(T ifNull, Func<DataRowExtended, T> f)
        {
            try
            {
                return f.Invoke(this);
            }
            catch (Exception)
            {
                return ifNull;
            }
        }

        public String StringValue(String columnName)
        {
            return dr[columnName].ToString();
        }

        public long LongValue(String columnName) {
            return Convert.ToInt64(dr[columnName].ToString());
        }

        public int IntValue(String columnName)
        {
            return Convert.ToInt32(dr[columnName].ToString());
        }

        public short ShortValue(String columnName)
        {
            return Convert.ToInt16(dr[columnName].ToString());
        }

        public Double DoubleValue(String columnName)
        {
            return Convert.ToDouble(dr[columnName].ToString());
        }
    }
}
