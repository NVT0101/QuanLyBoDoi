using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDoi
{
    public partial class MainForm
    {
        public void AddViewDataSource(List<People> people)
        {
            try
            {
                var source = new BindingSource();
                foreach (var p in people)
                {
                    source.Add(p);
                }

                TuyenHuanDataView.DataSource = source;
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "AddViewDataSource", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void SelectTemplate(object sender, EventArgs e)
        {
            try
            {
                //LoadMau ld = new LoadMau();
                Type thisType = this.GetType();
                MethodInfo theMethod = thisType.GetMethod($"LoadMau{ListTemplate.SelectedIndex + 1}");
                theMethod.Invoke(this, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}