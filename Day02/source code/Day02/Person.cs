using System;

namespace Day02
{
    /// <summary>
    ///     refer:https://goo.gl/4n73JC
    /// </summary>
    public abstract class Person
    {
        public abstract string Name { get; set; }
    }

    public class Author : Person
    {
        public override string Name { get; set; }
    }

    public class Reviewer : Person
    {
        public override string Name { get; set; }
    }

    public class TeamMember : Person
    {
        public override string Name { get; set; }
        public void GetMemberName()
        {
            Console.WriteLine($"Member name:{Name}");
        }
    }

    public class ContentMember : TeamMember
    {
        public ContentMember(string name)
        {
            base.Name = name;
        }
        public void GetContentMemberName()
        {
            base.GetMemberName();
        }
    }

    public class Stackholder
    {
        public void GetAuthorName(Person person)
        {
            var authorName = person as Author;
            Console.WriteLine(authorName != null ? $"Author is {authorName.Name}" : "No author.");
        }

        public void GetStackholdersname(Person person)
        {
            if (person is Author)
                Console.WriteLine($"Author name:{((Author) person).Name}");
            else if (person is Reviewer)
                Console.WriteLine($"Reviewer name:{((Reviewer) person).Name}");
            else if (person is TeamMember)
                Console.WriteLine($"Member name:{((TeamMember) person).Name}");
            else
                Console.Write("Not a valid name.");
        }
    }
}