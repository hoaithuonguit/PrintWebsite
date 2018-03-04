using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Responsity;
using Data.Dto;
using System.Data.Entity;

namespace WebsileBL.DataResponse
{
    public class UserReponse
    {
        protected Web_PrintEntities db = new Web_PrintEntities();
        public int GetIDUser()
        {
            int id = 0;
            using(db)
            {
                var result = (from a in db.M_User_Login
                              select a);
                id = result.Count() + 1;
            }
            return id;
        }

        public String CheckEmailOrPhoneNo(String _email, String _phoneNo)
        {
            using (db)
            {
                String res = "";
                int key = 0;
                var resultEmail = (from a in db.M_User_Detail
                                   where a.Email.ToUpper().Equals(_email.ToUpper())
                                   select a).FirstOrDefault();
                if (resultEmail != null)
                {
                    res += "Email ";
                    key = 1;
                }
                var resultPhone = (from a in db.M_User_Detail
                                   where a.PhoneNo.Equals(_phoneNo)
                                   select a).FirstOrDefault();
                if (resultPhone != null)
                {
                    if (key == 1) res += "and Phone";
                    else res += "Phone";
                }
                if (res != "") return "Success";
                else return res += " is exist!";
            }
        }
        public String CreateUser(String _username,
            String _password,
            String _address,
            String _phoneNo,
            String _email,
            String _userRole)
        {
            using (db)
            {
                if (CheckEmailOrPhoneNo(_email, _phoneNo) != "Success")
                    return CheckEmailOrPhoneNo(_email, _phoneNo);
                else
                {
                    int id = GetIDUser();
                    M_User_Detail userDetail = new M_User_Detail()
                    {
                        ID = id,
                        Address = _address,
                        Email = _email,
                        FullName = _username,
                        PhoneNo = _phoneNo,
                        CreateDt = DateTime.Now
                    };
                    M_User_Login userLogin = new M_User_Login()
                    {
                        ID = id,
                        Email = _email,
                        Password = _password,
                        User_Role = _userRole
                    };
                    try
                    {
                        db.M_User_Detail.Add(userDetail);
                        db.M_User_Login.Add(userLogin);
                        db.Entry(userLogin).State = EntityState.Added;
                        db.Entry(userDetail).State = EntityState.Added;
                        db.SaveChanges();
                        return "Create User Success";
                    }
                    catch (Exception ex) {
                        return ex.ToString();
                    }
                }
            }
        }


    }
}
