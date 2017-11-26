using Dvd.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvd.Data.Interfaces
{
    public interface IDvdDomain
    {
        void AddDVD(DVD dvd);
        void UpdateDVD(DVD dvd);

        DVD GetDVD(int dvdId);

        List<DVD> GetDVDlist();
    }
}
