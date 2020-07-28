using ClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Client
{
    class PhoneRepository
    {
        const string PATH_TO_API = "http://localhost:7829/PhoneHandler/";

        public List<Phone> sendGet()
        {
            List<Phone> Phones;
            var request = System.Net.WebRequest.Create(PATH_TO_API);
            request.Method = "GET";

            var response = request.GetResponse();

            using (var stream = new StreamReader(response.GetResponseStream() ?? throw new InvalidOperationException(), Encoding.UTF8))
            {
                return Phones = JsonSerializer.Deserialize<List<Phone>>(stream.ReadToEnd());
            }
        }

        public void sendPost(Phone phone)
        {
            var request = System.Net.WebRequest.Create(PATH_TO_API);
            request.Method = "POST";

            string data = JsonSerializer.Serialize<Phone>(phone);

            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);

            request.ContentLength = byteArray.Length;

            //записываем данные в поток запроса
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }
        }

        public void sendPut(Phone phone)
        {
            var request = System.Net.WebRequest.Create(PATH_TO_API);
            request.Method = "PUT";

            string data = JsonSerializer.Serialize<Phone>(phone);

            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);

            request.ContentLength = byteArray.Length;

            //записываем данные в поток запроса
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }
        }

        public void sendDelete(Phone phone)
        {
            var request = System.Net.WebRequest.Create(PATH_TO_API);
            request.Method = "DELETE";

            string data = JsonSerializer.Serialize<Phone>(phone);

            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);

            request.ContentLength = byteArray.Length;

            //записываем данные в поток запроса
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }
        }
    }
}
