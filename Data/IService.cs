using System.Collections.Generic;
using Models;

namespace Assignment1.Data
{
    public interface IService
    {
        IList<Adult> GetAdults();

        void AddAdult(Adult adult);

        void RemoveAdult(Adult adult);

        void Update(Adult adult);
    }
}