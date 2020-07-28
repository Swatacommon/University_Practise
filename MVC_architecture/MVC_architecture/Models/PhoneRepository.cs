using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Web;

namespace MVC_architecture.Models
{
    public sealed class PhoneRepository : IRepository<Phone>
    {
        static public List<Phone> Phones { get; set; } = new List<Phone>();

        public void SaveModel()
        {
            string json = JsonSerializer.Serialize<List<Phone>>(Phones);
            File.WriteAllText(@"D:\Studying\Course_3\Second_2sem\University_Practise\MVC_architecture\MVC_architecture\Models\PhonesDB.json", json);

        }

        public void LoadModel()
        {
            Phones = JsonSerializer.Deserialize<List<Phone>>(File.ReadAllText(@"D:\Studying\Course_3\Second_2sem\University_Practise\MVC_architecture\MVC_architecture\Models\PhonesDB.json"));
        }

        public void Add(Phone item)
        {
            if (item != null)
            {
                int lastId = Phones.Max(i => i.Id);
                item.Id = lastId + 1;
                var checkExistPhone = Get(item.Id);
                if (checkExistPhone == null)
                {
                    Phones.Add(item);
                    SaveModel();
                }
            }
        }

        public void Dispose()
        {
        }

        public IEnumerable<Phone> GetAllPhones()
        {
            LoadModel();
            Phones.OrderBy(n => n.Last_name);
            return Phones;
        }

        public bool Remove(Phone item)
        {
            var phone = Get(item.Id);
            if (phone != null && item != null)
            {
                Phones.Remove(item);
                SaveModel();
                return true;
            }
            return false;
        }

        public void Update(Phone item)
        {
            if (item != null)
            {
                var phone = Get(item.Id);
                if (phone != null)
                {
                    Phones.Remove((Phone)phone);
                    phone.Last_name = item.Last_name;
                    phone.Phone_number = item.Phone_number;
                    Phones.Add(phone);
                    SaveModel();

                }
            }

        }

        public Phone Get(int ID)
        {
            return Phones.FirstOrDefault(t => t.Id == ID);
        }
    }
}