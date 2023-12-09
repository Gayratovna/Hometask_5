using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_5
{
    public interface IPerson
    {
       public void GetData();
       public void ComparisonAge(int age);
       public bool IsHavePassport();
    }
}
