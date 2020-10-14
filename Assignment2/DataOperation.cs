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
            var type = typeof(T);


            var sql = new StringBuilder("INSERT INTO ").Append(type.Name).Append(" VALUES(");
            var sql2 = new StringBuilder("Select ").Append("SCOPE_IDENTITY();");
            var sql3 = new StringBuilder("INSERT INTO ").Append("Room").Append(" VALUES("); 
            
            int i = 1;


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

                            //Console.WriteLine(value.GetType().GetProperty("Rent").GetValue(value));
                            sql3.Append("'").Append(value.GetType().GetProperty("Rent").GetValue(value)).Append("'");

                            sql3.Append(",");

                            //sql.Append()
    

                        }
                    }

                }

            }

            Console.WriteLine(sql.ToString());
            Console.WriteLine(sql2.ToString());
            //ModifyTable modify = new ModifyTable();
            //int Houseid=modify.DatabaseGateway(sql.ToString(), sql2.ToString());

            //Console.WriteLine("yes"+Houseid);

        }
    }   
}
