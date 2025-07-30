using Microsoft.AspNetCore.Builder;

namespace LivestockData.Test.Config;

public class EnvironmentTest
{

   [Fact]
   public void IsNotDevModeByDefault()
   { 
       var builder = WebApplication.CreateEmptyBuilder(new WebApplicationOptions());
       var isDev = LivestockData.Config.Environment.IsDevMode(builder);
       Assert.False(isDev);
   }
}
