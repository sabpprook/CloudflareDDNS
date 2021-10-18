using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudflareDDNS
{
    public partial class fmSyncList : MetroFramework.Forms.MetroForm
    {
        public fmSyncList()
        {
            InitializeComponent();
        }

        private async void fmSyncList_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            var syncList = ((fmGUI)this.Owner).setting.syncList.result;
            foreach (var rec in syncList)
            {
                var result = (await Task.Run(() => API.GetDNSRecordInfo(rec))).result;
                if (result != null)
                {
                    dataGridView.Rows.Add(result.id, result.type, result.name, result.content, result.ttl, result.proxied);
                }
            }
        }
    }
}
