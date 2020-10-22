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
            DataServer modify = new DataServer();
            int Houseid=0;
            var type = typeof(T);

            var sql = new StringBuilder("INSERT INTO ").Append(type.Name).Append(" VALUES(");
            var sql2 = new StringBuilder("Select ").Append("SCOPE_IDENTITY();");
           
            
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
                            var sql3 =  new StringBuilder("INSERT INTO ").Append("Room").Append(" VALUES("); 

                            sql3.Append("'").Append(value.GetType().GetProperty("Rent").GetValue(value)).Append("'");

                            sql3.Append(",");

                            sql3.Append("'").Append(Houseid).Append("'");
                            sql3.Append(");");
                         
                            modify.DatabaseGateway2(sql3.ToString());
                        }                        
                    }
                }
            }                   
        }

        public void Update(T item)
        {
            var type = typeof(T);
           

            foreach (var prop in item.GetType().GetProperties())
            {
                if (prop.PropertyType.IsGenericType)
                {
                    Type t = item.GetType();

                    var props = t.GetProperties().Where(x => x.PropertyType.IsGenericType);

                    foreach (var propt in props)
                    {
                        var list = (IList)propt.GetValue(item);

                        foreach (var value in list)
                        {
                            var UpSql = new StringBuilder("UPDATE Room SET Rent = ");
                            UpSql.Append(value.GetType().GetProperty("Rent").GetValue(value));
                            UpSql.Append(" Where Id = ");
                            UpSql.Append(value.GetType().GetProperty("Id").GetValue(value));

                            
                            DataServer dataServer = new DataServer();
                            dataServer.DatabaseGateway2(UpSql.ToString());

                        }
                    }
                }
            }          
        }


        public void Delete(T item)
        {
            var type = typeof(T);
           

            foreach (var prop in item.GetType().GetProperties())
            {
                if (prop.PropertyType.IsGenericType)
                {
                    Type t = item.GetType();

                    var props = t.GetProperties().Where(x => x.PropertyType.IsGenericType);

                    foreach (var propt in props)
                    {
                        var list = (IList)propt.GetValue(item);

                        foreach (var value in list)
                        {
                            var DelSql = new StringBuilder("DELETE FROM Room WHERE Id=");
                            DelSql.Append(value.GetType().GetProperty("Id").GetValue(value));

                            DataServer dataServer = new DataServer();
                            dataServer.DatabaseGateway2(DelSql.ToString());
                        }
                    }
                }
            }            
        }

        public void GetById(int id)
        {
            var GetIdSq = new StringBuilder("Select * from Room where HouseId=").Append(id).ToString();

            DataServer obj = new DataServer();
            obj.ReadFromTable(GetIdSq);
        }

        public void GetAll()
        {
            var GetAllSql = "Select * from Room";
            DataServer obj = new DataServer();
            obj.ReadFromTable(GetAllSql);
        }        
    }
}
