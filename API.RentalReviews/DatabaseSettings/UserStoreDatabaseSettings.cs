using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.RentalReviews.DatabaseSettings
{
    public class UserStoreDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string UsersCollectionName { get; set; } = null!;
    }
}
