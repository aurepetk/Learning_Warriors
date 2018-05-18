using Warriors;

namespace People
{
    class Student: Person
    {
        public Student (string name, int id, Gender gender, int age)
            : base(name, id, gender, age)
        {

        }

        public void Action()
        {
            Work("Learns hard to pass exams.");
        }
    }
}
