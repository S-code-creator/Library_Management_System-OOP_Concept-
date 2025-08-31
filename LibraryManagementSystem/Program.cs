using LibraryManagementSystem;
using LibraryManagementSystem.Utils;


public class Program
{
    public static void Main(string[] arg)
    {
        //class: Book, Member, Librarian

        //Book book = new Book(DateTime.Now , 10);

        //book.Author = "John Deo";
        //book.Category = "Programming";

        //book.bookCount();
        //book.Borrow();
        //book.bookCount();




        //Inheritance

        //StudentMember Student = new StudentMember();
        //Student.Name = "Sabbir";
        //Student.MemberID = 1;
        //Student.MemberType = MemberTypeEnum.Student;

        //TeacherMember Teacher = new TeacherMember();
        //Teacher.Name = "Rakib";
        //Teacher.MemberID = 2;
        //Teacher.MemberType = MemberTypeEnum.Teacher;


        //GustMember Gust = new GustMember();
        //Gust.Name = "Mahamud";
        //Gust.MemberID = 3;
        //Gust.MemberType = MemberTypeEnum.Gust;

        Member Student = new StudentMember();
        Member Teacher = new TeacherMember();
        Member Gust = new GustMember();

        List<Member> members = new List<Member>();
        members.Add(Student);
        members.Add(Teacher);
        members.Add(Gust);

        Librarian librerian = new Librarian();
        


        Librarian.GetAllMember(members);



    }
}