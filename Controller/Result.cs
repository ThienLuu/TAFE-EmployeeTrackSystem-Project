using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//...
using DataAccess;
using Model;

namespace Controller
{
    public class Result<D>
    {
        public ResultEnumCheck Status { get; set; }
        public List<D> Data { get; set; }
    }
}
