using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneMode.Models
{
    class WeekLog:ICloneable
    {

        public string Name { get; set; }

        public int Age { get; set; }

        public string Date { get; set; }

        public string Content { get; set; }

        /// <summary>
        /// 附件，通过深复制或浅复制来实现
        /// </summary>
        public List<Attachment> Attachments { get; set; }

        public object Clone()
        {
            var obj=new WeekLog();
            obj.Name = Name;
            obj.Age = Age;
            obj.Date = Date;
            obj.Content = Content;

            obj.Attachments = Attachments;//通过浅复制来实现

            return obj;
        }
    }
}
