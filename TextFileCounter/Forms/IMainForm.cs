using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileCounter.Forms
{
    interface IMainForm
    {
        bool ValidateInputFile();
        bool ValidateOutputFile();
    }
}
