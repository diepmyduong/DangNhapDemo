using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Biz
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string CreateAt { get; set; }

        //Đăng nhập
        //Thành công tra về true
        //Thất bại trả về false
        public bool login(string password)
        {
            if (this.Password == password)
            {
                //Đúng pass
                return true;
            }
            else
            {
                return false;
            }
        }

        //Đăng ký
        //Thành công trả về true
        //Thất bại trả về false
        public bool signUp()
        {
            if (Dal.UserContext.save(this) != 0)
            {
                return true;
            }
            return false;
        }
    }
}
