using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brivia.Web.Data.Entities
{
    public class GameDetailEntity
    {
        public int Id { get; set; }

        public int IdGame { get; set; }

        public int IdUser { get; set; }

        public int IdCategory { get; set; }
    }
}
