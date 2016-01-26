using Dergi.Model.Repo;

namespace Dergi.Model
{
  public  class Bolge:BaseEntity
    {
      public string Name { get; set; }
      public Util.StatusType Status { get; set; }
    }
}
