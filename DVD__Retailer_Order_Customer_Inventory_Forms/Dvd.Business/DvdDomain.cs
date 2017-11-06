using Dvd.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dvd.Data.Model;
using Dvd.Data.Interfaces.Store;
using Dvd.Store;

namespace Dvd.Business
{
    public class DvdDomain : IDvdDomain
    {
        public void AddDVD(DVD dvd)
        {
            throw new NotImplementedException();
        }

        public DVD GetDVD(int dvdId)
        {
            throw new NotImplementedException();
        }

        public List<DVD> GetDVDlist()
        {
            throw new NotImplementedException();
        }

        public void UpdateDVD(DVD dvd)
        {
            throw new NotImplementedException();
        }
    }
}
