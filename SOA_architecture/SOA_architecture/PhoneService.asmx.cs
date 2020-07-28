using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services;

namespace SOA_architecture
{
    /// <summary>
    /// Сводное описание для PhoneService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class PhoneService : System.Web.Services.WebService
    {

        private PhoneRepository phoneRepository;

        public PhoneService()
        {
            phoneRepository = new PhoneRepository();
        }

        [WebMethod]
        public List<Phone> GetPhones()
        {
            return phoneRepository.GetAll().ToList();
        }

        [WebMethod]
        public void AddPhone(Phone phone)
        {
            phoneRepository.Add(phone);
        }

        [WebMethod]
        public void UpdPhone(Phone phone)
        {
            phoneRepository.Update(phone);
        }

        [WebMethod]
        public bool DelPhone(Phone phone)
        {
            return phoneRepository.Remove(phone);
        }

    }
}
