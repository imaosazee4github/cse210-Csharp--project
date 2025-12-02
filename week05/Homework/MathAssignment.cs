public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    //The base constructor for common attributes

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    //function specific to MathAssignment
    public string GetHomeworkList()
    {
      return  $"Section {_textbookSection} Problems {_problems}";
    }
}