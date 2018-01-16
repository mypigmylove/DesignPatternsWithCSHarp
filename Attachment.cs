using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneMode.Models
{
    class Attachment
    {
        public string Name { get; set; }

        public void Download()
        {
            Console.WriteLine("DownLoad Method");
        }
    }
}
