using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ChromeLoginPage : LoginPage
    {
        public WebElement loginButton()
        {
            return new WebElement("Log in");
        }
        public WebElement usernameInput()
        {
            return new WebElement("user");
        }
        public WebElement passwordInput()
        {
            return new WebElement("lozinka");
        }
    }
}
