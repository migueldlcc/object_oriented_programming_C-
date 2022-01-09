using System;

namespace StructOrClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // First let's look at a class.
            // Instantiate a StudentClass object and set its Level property to Freshman.
            var sc = new StudentClass();
            sc.Level = ClassStanding.Freshman;
            // Create a second StudentClass variable and set it equal to the first.
            var sc_copy = sc;
            // Call the Display method to display the values to the console.
            Console.WriteLine("THE CLASS OBJECTS' VALUES BEFORE CHANGING THE PROPERTY:");
            Display(sc, sc_copy);
            // Change the value of the Level property in the original object.
            sc.Level = ClassStanding.Sophomore;
            // Call the Display method again. Notice that sc_copy and sc are actually pointing to the same object.
            Console.WriteLine("THE CLASS OBJECTS' VALUES AFTER CHANGING THE PROPERTY IN THE ORIGINAL OBJECT:");
            Display(sc, sc_copy);

            // Now let's do the same thing with a structure.
            // Instantiate a StudentStructure object and set its Level property to Freshman.
            var ss = new StudentStructure();
            ss.Level = ClassStanding.Freshman;
            // Create a second StudentStructure variable and set it equal to the first.
            var ss_copy = ss;
            Console.WriteLine("THE STRUCTURE OBJECTS' VALUES BEFORE CHANGING THE PROPERTY:");
            Display(ss, ss_copy);
            // Change the value of the Level property in the original object.
            ss.Level = ClassStanding.Sophomore;
            // Call the Display method again. Notice that ss and ss_copy point to two different objects.
            Console.WriteLine("THE STRUCTURE OBJECTS' VALUES AFTER CHANGING THE PROPERTY IN THE ORIGINAL OBJECT:");
            Display(ss, ss_copy);

            Console.WriteLine("Press enter to quit...");
            Console.ReadLine();
        }

        static void Display(object student_class_or_struct, object student_class_or_struct_copy)
        {
            if (student_class_or_struct is StudentClass)
            {
                StudentClass s = (StudentClass)student_class_or_struct;
                StudentClass s_copy = (StudentClass)student_class_or_struct_copy;
                Console.WriteLine("Original object: " + s.Level);
                Console.WriteLine(" Copy: " + s_copy.Level + "\n");
            }
            if (student_class_or_struct is StudentStructure)
            {
                StudentStructure s = (StudentStructure)student_class_or_struct;
                StudentStructure s_copy = (StudentStructure)student_class_or_struct_copy;
                Console.WriteLine("Original object: " + s.Level);
                Console.WriteLine(" Copy: " + s_copy.Level + "\n");
            }
        }
    }
}
