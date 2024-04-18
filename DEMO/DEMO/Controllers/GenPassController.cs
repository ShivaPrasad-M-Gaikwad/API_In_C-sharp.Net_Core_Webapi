using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DEMO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenPassController : ControllerBase
    {

        [HttpGet]
        public string getpass(int size)
        {
            return Gen(10);
        }

        public string Gen(int size)
        {
            string StoredPassword;
            char Generated_Password;

            StringBuilder SB = new StringBuilder();
            Random Rand = new Random();
            for (int i = 0; i < size; i++)
            {
                Generated_Password = (char)Rand.Next(33, 126);
                SB.Append(Generated_Password);
            }
            StoredPassword = SB.ToString();
            return StoredPassword;
        }
    }
}
