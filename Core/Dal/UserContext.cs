using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Biz;
using System.Data.SqlClient;
using System.Data;

namespace Core.Dal
{
    public class UserContext
    {
        public static List<User> getAll()
        {
            Database db = new Database();
            List<User> users = new List<User>();

            string queryString = "select * from Users";
            SqlDataReader reader = db.query(queryString);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    User user = new User();
                    user.Username = reader["username"].ToString();
                    user.Password = reader["password"].ToString();
                    user.CreateAt = reader["create_at"].ToString();
                    users.Add(user);
                }
            }
            db.Disconnect();
            return users;
        }

        public static User find(string username)
        {
            Database db = new Database();
            string queryString = "select * from Users where username = @username";
            List<SqlParameter> atrs = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@username",SqlDbType= SqlDbType.NVarChar,Value = username }
            };
            SqlDataReader reader = db.query(queryString, atrs);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    User user = new User();
                    user.Username = reader["username"].ToString();
                    user.Password = reader["password"].ToString();
                    user.CreateAt = reader["create_at"].ToString();
                    return user;
                }
            }
            db.Disconnect();
            return null;
        }

        public static int update(User user)
        {
            try
            {
                Database db = new Database();
                string queryString = "UPDATE [dbo].[Users] SET [password] = @password WHERE [username] = @username";
                List<SqlParameter> atrs = new List<SqlParameter>()
                {
                    new SqlParameter() {ParameterName = "@username",SqlDbType= SqlDbType.NVarChar,Value = user.Username },
                    new SqlParameter() {ParameterName = "@password",SqlDbType= SqlDbType.NVarChar,Value = user.Password }
                };
                int result = db.execute(queryString, atrs);
                db.Disconnect();
                return result;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
           
        }

        public static int save(User user)
        {
            try
            {
                Database db = new Database();
                string queryString = "INSERT INTO [dbo].[Users]([username],[password],[create_at]) VALUES(@username,@password,GETDATE())";
                List<SqlParameter> atrs = new List<SqlParameter>()
                {
                    new SqlParameter() {ParameterName = "@username",SqlDbType= SqlDbType.NVarChar,Value = user.Username },
                    new SqlParameter() {ParameterName = "@password",SqlDbType= SqlDbType.NVarChar,Value = user.Password }
                };
                int result = db.execute(queryString, atrs);
                db.Disconnect();
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }

        }

        public static int delete(string username)
        {
            try
            {
                Database db = new Database();
                string queryString = "DELETE FROM [dbo].[Users] WHERE [username] = @username";
                List<SqlParameter> atrs = new List<SqlParameter>()
                {
                    new SqlParameter() {ParameterName = "@username",SqlDbType= SqlDbType.NVarChar,Value = username }
                };
                int result = db.execute(queryString, atrs);
                db.Disconnect();
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            
        }
    }
}
