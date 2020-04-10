using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/Palindrome")]
    public class PalindromeController : ApiController
    {
        [ResponseType(typeof(bool))]
        [HttpPost]
        [Route("IsPalindrome")]
        public async Task<IHttpActionResult> IsPalindrome([FromBody] string word)
        {
            try
            {
                var orig = word;
                Array.Reverse(word.ToArray());
                Console.WriteLine(word);
                return Ok(orig.Equals(word));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
           
        }
       
    }
}
