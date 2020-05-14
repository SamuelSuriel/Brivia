using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brivia.Web.Data.Entities
{
    public class GameEntity
    {
        public int Id { get; set; }

        public int IdUser1 { get; set; }

        public int IdUser2 { get; set; }

        public string Turn { get; set; }

        public DateTime Date { get; set; }

        public string Round { get; set; }

        public int Correctsanswers1 { get; set; }

        public string Characters1 { get; set; }

        public int Correctsanswers2 { get; set; }

        public string Characters2 { get; set; }
    }
}
