using Dvd.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvd.Data.Interfaces.Store
{
    public interface IDvdStore
    {
        int AddDVD(DVD dvd);
        int UdpateDVD(DVD dvd);

        DVD GetDVD(int dvd_ID);

        int DeleteDVD(int dvd_ID);

        List<DVD> GetDVDs();
    }
}
