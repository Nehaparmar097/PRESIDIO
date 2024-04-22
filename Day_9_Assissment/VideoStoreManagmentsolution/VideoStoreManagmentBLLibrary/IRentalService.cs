using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStoreManagmentBLLibrary
{   /// <summary>
   /// given rental services
  /// </summary>
    public interface IRentalService
    {

        void RentVideo(int customerId, int videoId);
        void ReturnVideo(int customerId, int videoId);
    }
}
