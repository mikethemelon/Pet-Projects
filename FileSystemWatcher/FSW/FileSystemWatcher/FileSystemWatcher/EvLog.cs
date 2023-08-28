using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSystemWatcher
{
    public partial class EvLog : Form
    {
        public EvLog()
        {
            InitializeComponent();
            cmblog.Items.Clear();
            EventLog[] xlog = EventLog.GetEventLogs();
            foreach (EventLog x in xlog)
            {
                cmblog.Items.Add(x.Log);
            }
            r1.Checked = true;
            r2.Checked = false;
            cmblog.Visible = true;
            tcustom.Visible = false;
        }

        private void bView_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string logname = "";
            try
            {
                int dem = 0;
                logname = cmblog.Text;
                label2.Text = "Dang doc event tu log... " + logname;
                if (EventLog.Exists(logname))
                {
                    EventLog xel = new EventLog(logname);
                    EventLogEntryCollection xlog = xel.Entries;
                    foreach (EventLogEntry x in xlog)
                    {
                        dem++;
                        listBox1.Items.Add(dem + ". " + x.TimeWritten + ", " + x.Source + "--|-- " + x.Message);
                    }
                    label2.Text = dem.ToString() + " Events";
                }
            }
            catch (Exception error)
            {
                ghilog("Apllication", "Error View Log Security");
            }
        }

        private void ghilog(string logname, string message)
        {
            try
            {
                EventLog xlog = new EventLog();
                xlog.MachineName = ".";
                xlog.Log = "Application";
                if (!EventLog.SourceExists("MyEventSource"))
                {
                    EventLog.CreateEventSource("MyEventSource", "Application");
                }
                xlog.Source = "MyEventSource";
                xlog.WriteEntry(message);
            }
            catch (Exception eee)
            {
                label2.Text = "loi ghi log";
            }
        }
        private void ghilog2(string logname, string message)
        {

            string source = "View log";
            string log = logname;
            EventLog demolog = new EventLog(log);
            demolog.MachineName = ".";
            if (!EventLog.SourceExists(source))
            {
                EventLog.CreateEventSource(source, log);
            }
            int EventID = 8;
            demolog.Source = source;
            demolog.WriteEntry(message, EventLogEntryType.Information, EventID);

            label2.Text = "Da luu!";
            demolog.Close();


        }

        

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void r1_CheckedChanged(object sender, EventArgs e)
        {
            if (r1.Checked)
            {
                cmblog.Visible = true;
                tcustom.Visible = false;
            }
        }

        private void r2_CheckedChanged(object sender, EventArgs e)
        {
            if (r2.Checked)
            {
                cmblog.Visible = false;
                tcustom.Visible = true;
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            //string custom = tcustom.Text;
            ghilog2("mylog", "" + listBox2.Text);
        }

        private void bFilter_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.SelectedIndex = 1;
                if (listBox1.Text.Contains(tfilter.Text)) ;
                {
                    listBox2.Items.Add(listBox1.Text);
                }
            }
            listBox2.Refresh();
        }

       
    }
}
