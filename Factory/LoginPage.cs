using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface LoginPage
    {
        public WebElement loginButton();
        public WebElement usernameInput();
        public WebElement passwordInput();
    }
}
