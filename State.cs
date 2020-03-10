using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    interface State
    {
         void Handle(Context context);
    }

}

