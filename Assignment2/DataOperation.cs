using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;
using System.Collections;

namespace Assignment2 
{
    public class DataOperation<T> where T : class
    {
        public void Insert(T item)
        {
            ModifyTable modify = new ModifyTable();
            int Houseid=0;
            var type = typeof(T);

            var sql = new StringBuilder("INSERT INTO ").Append(type.Name).Append(" VALUES(");
            var sql2 = new StringBuilder("Select ").Append("SCOPE_IDENTITY();");
            var sql3 = new StringBuilder("INSERT INTO ").Append("Room").Append(" VALUES("); 
            
            
            foreach (var prop in item.GetType().GetProperties())
            {
                var propValue = prop.GetValue(item, null);

                if (prop.Name == "Id")
                {

                }
               
                else if(prop.PropertyType.IsGenericType==false)
                {
                    sql.Append("'").Append(propValue).Append("'");
                    
                    sql.Append(");");
                    Houseid = modify.DatabaseGateway(sql.ToString(), sql2.ToString());
                }
                else if (prop.PropertyType.IsGenericType)
                {
                    Type t = item.GetType();

                    var props = t.GetProperties().Where(x => x.PropertyType.IsGenericType);

                    foreach (var propt in props)
                    {
                        var list = (IList)propt.GetValue(item);

                        foreach (var value in list)
                        {
                            sql3.Append("'").Append(value.GetType().GetProperty("Rent").GetValue(value)).Append("'");

                            sql3.Append(",");

                            sql3.Append("'").Append(Houseid).Append("'");
                            sql3.Append(");");
                        }
                    }
                }
            }

            //Console.WriteLine(sql.ToString());
            //Console.WriteLine(sql2.ToString());
            //Console.WriteLine(sql3.ToString());
           
            modify.DatabaseGateway2(sql3.ToString());
          
        }
    }   
}
