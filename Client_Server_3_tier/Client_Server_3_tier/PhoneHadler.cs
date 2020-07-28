using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Web;

namespace Client_Server_3_tier
{
    public class PhoneHadler : IHttpHandler
    {
        PhoneContext db = new PhoneContext();

        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            if(context.Request.HttpMethod == "GET")
            {
                List<Phone> phones = db.Phones.ToList();
                string json = JsonSerializer.Serialize<List<Phone>>(phones);
                string result = json;
                context.Response.ContentType = "text/json";
                context.Response.StatusCode = 200;
                context.Response.Write(result);
            }
            if (context.Request.HttpMethod == "POST")
            {
                var reader = new StreamReader(context.Request.InputStream);
                var inputString = reader.ReadToEnd();
                Phone newPhone = JsonSerializer.Deserialize<Phone>(inputString);
                db.Phones.Add(newPhone);
                db.SaveChanges();
            }
            if(context.Request.HttpMethod == "PUT")
            {
                var reader = new StreamReader(context.Request.InputStream);
                var inputString = reader.ReadToEnd();
                Phone newPhone = JsonSerializer.Deserialize<Phone>(inputString);
                var phone = db.Phones.FirstOrDefault(t=>t.Id == newPhone.Id);
                phone.Last_name= newPhone.Last_name;
                phone.Phone_number =  newPhone.Phone_number;
                db.SaveChanges();
            }
            if(context.Request.HttpMethod == "DELETE")
            {
                var reader = new StreamReader(context.Request.InputStream);
                var inputString = reader.ReadToEnd();
                Phone deletePhone = JsonSerializer.Deserialize<Phone>(inputString);
                db.Entry(deletePhone).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}