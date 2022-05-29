using System.Data;

namespace TagMaster_BL
{

    public class TagList : System.Data.DataTable
    {
        private DataTable m_data;

        public TagList()
        {
            m_data = new DataTable();
            m_data.Columns.Add("Vision_LabelName");
            m_data.Columns.Add("Vision_LabelConfidence");
            m_data.Columns.Add("Corrected_LabelName");
        }
    }
}