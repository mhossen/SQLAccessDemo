using System.Configuration;

namespace FormUI.Utilities
{
  public static class Helper
  {
    public static string ConnectionStringValue(string connectionStringName)
    {
      return ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
    }
  }
}
