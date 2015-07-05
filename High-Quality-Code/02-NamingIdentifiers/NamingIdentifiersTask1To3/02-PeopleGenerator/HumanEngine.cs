namespace NamingIdentifiersTask1To3.PeopleGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class HumanEngine
    {
        public void Generate(int age)
        {
            Human human = new Human();
            human.Age = age;
            if (age % 2 == 0)
            {
                human.Name = "Батката";
                human.Gender = Gender.Male;
            }
            else
            {
                human.Name = "Maцето";
                human.Gender = Gender.Female;
            }
        }
    }
}
