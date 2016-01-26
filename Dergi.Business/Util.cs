using System;

namespace Dergi.Business
{
  public  static class Util
    {
      public static int ConvertInt32(object o)
      {
          try
          {
             return Convert.ToInt32(o);
          }
          catch (Exception)
          {
              return 0;
          }
      }

      public static Decimal ConvertDecimal(object o)
      {
          try
          {
              return Convert.ToDecimal(o);
          }
          catch (Exception)
          {
              return 0;
          }
      }
    }
}
