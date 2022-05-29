using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TagMaster_BL
{
    public class TagList : System.Data.DataTable
    {
        public TagList()
        {
            this.Columns.Add("ImageBase64", typeof(String));
            this.Columns.Add("GV_TagName");
            this.Columns.Add("GV_Confidence");
            this.Columns.Add(new DataColumn("UseTag", typeof(Boolean)));
            this.Columns.Add(new DataColumn("Relevance", typeof(int)));
      
            this.Columns["UseTag"].DefaultValue = true;
            this.Columns["Relevance"].DefaultValue = 75;
            
            //this.PrimaryKey = new DataColumn[] { this.Columns["GV_TagName"] };
        }
    }
}