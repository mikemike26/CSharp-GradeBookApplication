using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
  public class StandardGradeBook : BaseGradeBook
  {
    public StandardGradeBook(string name, bool isWeighted) : base(name, bool isWeighted)
    {
      Type = GradeBookType.Standard;
    }
  }
}
