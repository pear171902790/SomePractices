using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace IQueryableAndQueryObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Model1Container();

            var person = new Person()
                {
                    Name = "aaa",
                    Age=12
                };
            container.People.AddObject(person);
            container.SaveChanges();

            Expression<Func<Person, bool>> expression2 = p => p.Age==12;
            Expression<Func<Person, bool>> expression = p => A(p);
            Expression<Func<Person, bool>> expression3 = p => p.Name=="aaa";
            var query=container.People.Where(expression2).Where(expression3);
            var q =  (ObjectQuery<Person>)query;
            var str = q.ToTraceString();
            var list = query.ToList();
            var b = 0;

        }

        private static bool A(Person p)
        {
            return p.Age == 12;
        }
    }
}
