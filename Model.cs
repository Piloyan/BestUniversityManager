using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestUniversityManager.Model
{
    public class Model
    {
        public Model()
        {

        }
        public Model(string firstName, string lastName, int age)
        {
            _id = Guid.NewGuid();
            _firstName = firstName;
            _lastName = lastName;
            _age = age;

        }
        public Guid _id;
        public string _firstName;
        public string _lastName;
        public int _age;
    }
}
