using ClassLibrary;
using System.Collections.Generic;
using System.Linq;

namespace WcfService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service1 : IService1
    {
        private CatRepository catRepository;
        public Service1()
        {
            catRepository = new CatRepository();
        }

        public List<Cat> GetCats()
        {
            return catRepository.GetAll().ToList();
        }

        public void AddCat(Cat cat)
        {
            catRepository.Add(cat);
        }

        public void UpdCat(Cat cat)
        {
            catRepository.Update(cat);
        }

        public bool DelCat(Cat cat)
        {
            return catRepository.Remove(cat);
        }
    }
}
