using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dto
{

    /// <summary>
    /// data khi login tra ve
    /// </summary>
    public class UserLoginResponseDto
    {
        public int UserRole { get; set; }
        public String PhoneNo { get; set; }
        public String Email { get; set; }
        public String FullName { get; set; }
    }
}
